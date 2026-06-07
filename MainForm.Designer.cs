namespace KeyLoggerClone
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnOpenLog = new System.Windows.Forms.Button();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.lblElapsedTimeVal = new System.Windows.Forms.Label();
            this.lblActiveAppVal = new System.Windows.Forms.Label();
            this.lblTotalKeysVal = new System.Windows.Forms.Label();
            this.lblStatusVal = new System.Windows.Forms.Label();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.lblActiveApp = new System.Windows.Forms.Label();
            this.lblTotalKeys = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpEmailSettings = new System.Windows.Forms.GroupBox();
            this.chkLogToEmail = new System.Windows.Forms.CheckBox();
            this.lblSmtpHost = new System.Windows.Forms.Label();
            this.txtSmtpHost = new System.Windows.Forms.TextBox();
            this.lblSmtpPort = new System.Windows.Forms.Label();
            this.txtSmtpPort = new System.Windows.Forms.TextBox();
            this.chkEnableSsl = new System.Windows.Forms.CheckBox();
            this.lblSenderEmail = new System.Windows.Forms.Label();
            this.txtSenderEmail = new System.Windows.Forms.TextBox();
            this.lblSenderPassword = new System.Windows.Forms.Label();
            this.txtSenderPassword = new System.Windows.Forms.TextBox();
            this.lblRecipientEmail = new System.Windows.Forms.Label();
            this.txtRecipientEmail = new System.Windows.Forms.TextBox();
            this.lblEmailNote = new System.Windows.Forms.Label();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.chkLogToFile = new System.Windows.Forms.CheckBox();
            this.chkRealtimeView = new System.Windows.Forms.CheckBox();
            this.btnToggleHook = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.rtxtLogView = new System.Windows.Forms.RichTextBox();
            this.pnlLogHeader = new System.Windows.Forms.Panel();
            this.btnClearView = new System.Windows.Forms.Button();
            this.lblLogHeaderTitle = new System.Windows.Forms.Label();
            this.timerStats = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.grpStats.SuspendLayout();
            this.grpEmailSettings.SuspendLayout();
            this.grpSettings.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlLogHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(27)))));
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(950, 75);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(22, 42);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(434, 15);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Object-Oriented Programming (OOP) Educational Demo - Keyboard Event Interceptor";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(18, 11);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(262, 30);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "KEYLOGGER CLONE - OOP";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.pnlSidebar.Controls.Add(this.btnOpenLog);
            this.pnlSidebar.Controls.Add(this.grpStats);
            this.pnlSidebar.Controls.Add(this.grpEmailSettings);
            this.pnlSidebar.Controls.Add(this.grpSettings);
            this.pnlSidebar.Controls.Add(this.btnToggleHook);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 75);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(280, 705);
            this.pnlSidebar.TabIndex = 1;
            // 
            // btnOpenLog
            // 
            this.btnOpenLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.btnOpenLog.FlatAppearance.BorderSize = 0;
            this.btnOpenLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnOpenLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenLog.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpenLog.ForeColor = System.Drawing.Color.White;
            this.btnOpenLog.Location = new System.Drawing.Point(15, 655);
            this.btnOpenLog.Name = "btnOpenLog";
            this.btnOpenLog.Size = new System.Drawing.Size(250, 35);
            this.btnOpenLog.TabIndex = 4;
            this.btnOpenLog.Text = "OPEN LOG FILE";
            this.btnOpenLog.UseVisualStyleBackColor = false;
            this.btnOpenLog.Click += new System.EventHandler(this.btnOpenLog_Click);
            // 
            // grpStats
            // 
            this.grpStats.Controls.Add(this.lblElapsedTimeVal);
            this.grpStats.Controls.Add(this.lblActiveAppVal);
            this.grpStats.Controls.Add(this.lblTotalKeysVal);
            this.grpStats.Controls.Add(this.lblStatusVal);
            this.grpStats.Controls.Add(this.lblElapsedTime);
            this.grpStats.Controls.Add(this.lblActiveApp);
            this.grpStats.Controls.Add(this.lblTotalKeys);
            this.grpStats.Controls.Add(this.lblStatus);
            this.grpStats.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.grpStats.Location = new System.Drawing.Point(15, 485);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(250, 160);
            this.grpStats.TabIndex = 3;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "INTERCEPTION STATS";
            // 
            // lblElapsedTimeVal
            // 
            this.lblElapsedTimeVal.AutoSize = true;
            this.lblElapsedTimeVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblElapsedTimeVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.lblElapsedTimeVal.Location = new System.Drawing.Point(100, 125);
            this.lblElapsedTimeVal.Name = "lblElapsedTimeVal";
            this.lblElapsedTimeVal.Size = new System.Drawing.Size(49, 15);
            this.lblElapsedTimeVal.TabIndex = 7;
            this.lblElapsedTimeVal.Text = "00:00:00";
            // 
            // lblActiveAppVal
            // 
            this.lblActiveAppVal.AutoEllipsis = true;
            this.lblActiveAppVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActiveAppVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.lblActiveAppVal.Location = new System.Drawing.Point(100, 90);
            this.lblActiveAppVal.Name = "lblActiveAppVal";
            this.lblActiveAppVal.Size = new System.Drawing.Size(140, 30);
            this.lblActiveAppVal.TabIndex = 6;
            this.lblActiveAppVal.Text = "None";
            // 
            // lblTotalKeysVal
            // 
            this.lblTotalKeysVal.AutoSize = true;
            this.lblTotalKeysVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalKeysVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.lblTotalKeysVal.Location = new System.Drawing.Point(100, 60);
            this.lblTotalKeysVal.Name = "lblTotalKeysVal";
            this.lblTotalKeysVal.Size = new System.Drawing.Size(13, 15);
            this.lblTotalKeysVal.TabIndex = 5;
            this.lblTotalKeysVal.Text = "0";
            // 
            // lblStatusVal
            // 
            this.lblStatusVal.AutoSize = true;
            this.lblStatusVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatusVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(139)))), ((int)(((byte)(168)))));
            this.lblStatusVal.Location = new System.Drawing.Point(100, 30);
            this.lblStatusVal.Name = "lblStatusVal";
            this.lblStatusVal.Size = new System.Drawing.Size(56, 15);
            this.lblStatusVal.TabIndex = 4;
            this.lblStatusVal.Text = "STOPPED";
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.AutoSize = true;
            this.lblElapsedTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblElapsedTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.lblElapsedTime.Location = new System.Drawing.Point(15, 125);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(60, 15);
            this.lblElapsedTime.TabIndex = 3;
            this.lblElapsedTime.Text = "Run Time:";
            // 
            // lblActiveApp
            // 
            this.lblActiveApp.AutoSize = true;
            this.lblActiveApp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActiveApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.lblActiveApp.Location = new System.Drawing.Point(15, 90);
            this.lblActiveApp.Name = "lblActiveApp";
            this.lblActiveApp.Size = new System.Drawing.Size(68, 15);
            this.lblActiveApp.TabIndex = 2;
            this.lblActiveApp.Text = "Active App:";
            // 
            // lblTotalKeys
            // 
            this.lblTotalKeys.AutoSize = true;
            this.lblTotalKeys.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalKeys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.lblTotalKeys.Location = new System.Drawing.Point(15, 60);
            this.lblTotalKeys.Name = "lblTotalKeys";
            this.lblTotalKeys.Size = new System.Drawing.Size(63, 15);
            this.lblTotalKeys.TabIndex = 1;
            this.lblTotalKeys.Text = "Total Keys:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.lblStatus.Location = new System.Drawing.Point(15, 30);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 15);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status:";
            // 
            // grpEmailSettings
            // 
            this.grpEmailSettings.Controls.Add(this.chkLogToEmail);
            this.grpEmailSettings.Controls.Add(this.lblSmtpHost);
            this.grpEmailSettings.Controls.Add(this.txtSmtpHost);
            this.grpEmailSettings.Controls.Add(this.lblSmtpPort);
            this.grpEmailSettings.Controls.Add(this.txtSmtpPort);
            this.grpEmailSettings.Controls.Add(this.chkEnableSsl);
            this.grpEmailSettings.Controls.Add(this.lblSenderEmail);
            this.grpEmailSettings.Controls.Add(this.txtSenderEmail);
            this.grpEmailSettings.Controls.Add(this.lblSenderPassword);
            this.grpEmailSettings.Controls.Add(this.txtSenderPassword);
            this.grpEmailSettings.Controls.Add(this.lblRecipientEmail);
            this.grpEmailSettings.Controls.Add(this.txtRecipientEmail);
            this.grpEmailSettings.Controls.Add(this.lblEmailNote);
            this.grpEmailSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpEmailSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.grpEmailSettings.Location = new System.Drawing.Point(15, 210);
            this.grpEmailSettings.Name = "grpEmailSettings";
            this.grpEmailSettings.Size = new System.Drawing.Size(250, 265);
            this.grpEmailSettings.TabIndex = 2;
            this.grpEmailSettings.TabStop = false;
            this.grpEmailSettings.Text = "EMAIL LOGGER SETTINGS";
            // 
            // chkLogToEmail
            // 
            this.chkLogToEmail.AutoSize = true;
            this.chkLogToEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkLogToEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.chkLogToEmail.Location = new System.Drawing.Point(15, 25);
            this.chkLogToEmail.Name = "chkLogToEmail";
            this.chkLogToEmail.Size = new System.Drawing.Size(149, 19);
            this.chkLogToEmail.TabIndex = 0;
            this.chkLogToEmail.Text = "Send Logs via Email";
            this.chkLogToEmail.UseVisualStyleBackColor = true;
            this.chkLogToEmail.CheckedChanged += new System.EventHandler(this.chkLogToEmail_CheckedChanged);
            // 
            // lblSmtpHost
            // 
            this.lblSmtpHost.AutoSize = true;
            this.lblSmtpHost.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSmtpHost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.lblSmtpHost.Location = new System.Drawing.Point(15, 50);
            this.lblSmtpHost.Name = "lblSmtpHost";
            this.lblSmtpHost.Size = new System.Drawing.Size(62, 13);
            this.lblSmtpHost.TabIndex = 1;
            this.lblSmtpHost.Text = "SMTP Host:";
            // 
            // txtSmtpHost
            // 
            this.txtSmtpHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtSmtpHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSmtpHost.Enabled = false;
            this.txtSmtpHost.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSmtpHost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.txtSmtpHost.Location = new System.Drawing.Point(15, 68);
            this.txtSmtpHost.Name = "txtSmtpHost";
            this.txtSmtpHost.Size = new System.Drawing.Size(105, 22);
            this.txtSmtpHost.TabIndex = 2;
            this.txtSmtpHost.Text = "smtp.gmail.com";
            // 
            // lblSmtpPort
            // 
            this.lblSmtpPort.AutoSize = true;
            this.lblSmtpPort.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSmtpPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.lblSmtpPort.Location = new System.Drawing.Point(130, 50);
            this.lblSmtpPort.Name = "lblSmtpPort";
            this.lblSmtpPort.Size = new System.Drawing.Size(31, 13);
            this.lblSmtpPort.TabIndex = 3;
            this.lblSmtpPort.Text = "Port:";
            // 
            // txtSmtpPort
            // 
            this.txtSmtpPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtSmtpPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSmtpPort.Enabled = false;
            this.txtSmtpPort.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSmtpPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.txtSmtpPort.Location = new System.Drawing.Point(130, 68);
            this.txtSmtpPort.Name = "txtSmtpPort";
            this.txtSmtpPort.Size = new System.Drawing.Size(50, 22);
            this.txtSmtpPort.TabIndex = 4;
            this.txtSmtpPort.Text = "587";
            // 
            // chkEnableSsl
            // 
            this.chkEnableSsl.AutoSize = true;
            this.chkEnableSsl.Checked = true;
            this.chkEnableSsl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableSsl.Enabled = false;
            this.chkEnableSsl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkEnableSsl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.chkEnableSsl.Location = new System.Drawing.Point(190, 71);
            this.chkEnableSsl.Name = "chkEnableSsl";
            this.chkEnableSsl.Size = new System.Drawing.Size(43, 17);
            this.chkEnableSsl.TabIndex = 5;
            this.chkEnableSsl.Text = "SSL";
            this.chkEnableSsl.UseVisualStyleBackColor = true;
            // 
            // lblSenderEmail
            // 
            this.lblSenderEmail.AutoSize = true;
            this.lblSenderEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSenderEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.lblSenderEmail.Location = new System.Drawing.Point(15, 95);
            this.lblSenderEmail.Name = "lblSenderEmail";
            this.lblSenderEmail.Size = new System.Drawing.Size(76, 13);
            this.lblSenderEmail.TabIndex = 6;
            this.lblSenderEmail.Text = "Sender Email:";
            // 
            // txtSenderEmail
            // 
            this.txtSenderEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtSenderEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenderEmail.Enabled = false;
            this.txtSenderEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenderEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.txtSenderEmail.Location = new System.Drawing.Point(15, 113);
            this.txtSenderEmail.Name = "txtSenderEmail";
            this.txtSenderEmail.Size = new System.Drawing.Size(220, 22);
            this.txtSenderEmail.TabIndex = 7;
            // 
            // lblSenderPassword
            // 
            this.lblSenderPassword.AutoSize = true;
            this.lblSenderPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSenderPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.lblSenderPassword.Location = new System.Drawing.Point(15, 140);
            this.lblSenderPassword.Name = "lblSenderPassword";
            this.lblSenderPassword.Size = new System.Drawing.Size(120, 13);
            this.lblSenderPassword.TabIndex = 8;
            this.lblSenderPassword.Text = "Sender App Password:";
            // 
            // txtSenderPassword
            // 
            this.txtSenderPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtSenderPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenderPassword.Enabled = false;
            this.txtSenderPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenderPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.txtSenderPassword.Location = new System.Drawing.Point(15, 158);
            this.txtSenderPassword.Name = "txtSenderPassword";
            this.txtSenderPassword.PasswordChar = '*';
            this.txtSenderPassword.Size = new System.Drawing.Size(220, 22);
            this.txtSenderPassword.TabIndex = 9;
            // 
            // lblRecipientEmail
            // 
            this.lblRecipientEmail.AutoSize = true;
            this.lblRecipientEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecipientEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.lblRecipientEmail.Location = new System.Drawing.Point(15, 185);
            this.lblRecipientEmail.Name = "lblRecipientEmail";
            this.lblRecipientEmail.Size = new System.Drawing.Size(88, 13);
            this.lblRecipientEmail.TabIndex = 10;
            this.lblRecipientEmail.Text = "Recipient Email:";
            // 
            // txtRecipientEmail
            // 
            this.txtRecipientEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtRecipientEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecipientEmail.Enabled = false;
            this.txtRecipientEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecipientEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.txtRecipientEmail.Location = new System.Drawing.Point(15, 203);
            this.txtRecipientEmail.Name = "txtRecipientEmail";
            this.txtRecipientEmail.Size = new System.Drawing.Size(220, 22);
            this.txtRecipientEmail.TabIndex = 11;
            // 
            // lblEmailNote
            // 
            this.lblEmailNote.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblEmailNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.lblEmailNote.Location = new System.Drawing.Point(15, 230);
            this.lblEmailNote.Name = "lblEmailNote";
            this.lblEmailNote.Size = new System.Drawing.Size(220, 30);
            this.lblEmailNote.TabIndex = 12;
            this.lblEmailNote.Text = "Logs are sent asynchronously every 200 chars or when stopped.";
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.btnBrowse);
            this.grpSettings.Controls.Add(this.txtFilePath);
            this.grpSettings.Controls.Add(this.lblFilePath);
            this.grpSettings.Controls.Add(this.chkLogToFile);
            this.grpSettings.Controls.Add(this.chkRealtimeView);
            this.grpSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.grpSettings.Location = new System.Drawing.Point(15, 70);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(250, 130);
            this.grpSettings.TabIndex = 1;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "GENERAL SETTINGS";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(195, 97);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(45, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilePath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.txtFilePath.Location = new System.Drawing.Point(15, 98);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(175, 22);
            this.txtFilePath.TabIndex = 3;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.lblFilePath.Location = new System.Drawing.Point(15, 80);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(53, 13);
            this.lblFilePath.TabIndex = 2;
            this.lblFilePath.Text = "File Path:";
            // 
            // chkLogToFile
            // 
            this.chkLogToFile.AutoSize = true;
            this.chkLogToFile.Checked = true;
            this.chkLogToFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLogToFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkLogToFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.chkLogToFile.Location = new System.Drawing.Point(15, 55);
            this.chkLogToFile.Name = "chkLogToFile";
            this.chkLogToFile.Size = new System.Drawing.Size(139, 19);
            this.chkLogToFile.TabIndex = 1;
            this.chkLogToFile.Text = "Save Keystrokes to File";
            this.chkLogToFile.UseVisualStyleBackColor = true;
            this.chkLogToFile.CheckedChanged += new System.EventHandler(this.chkLogToFile_CheckedChanged);
            // 
            // chkRealtimeView
            // 
            this.chkRealtimeView.AutoSize = true;
            this.chkRealtimeView.Checked = true;
            this.chkRealtimeView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRealtimeView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkRealtimeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.chkRealtimeView.Location = new System.Drawing.Point(15, 25);
            this.chkRealtimeView.Name = "chkRealtimeView";
            this.chkRealtimeView.Size = new System.Drawing.Size(155, 19);
            this.chkRealtimeView.TabIndex = 0;
            this.chkRealtimeView.Text = "Show Real-time UI logs";
            this.chkRealtimeView.UseVisualStyleBackColor = true;
            this.chkRealtimeView.CheckedChanged += new System.EventHandler(this.chkRealtimeView_CheckedChanged);
            // 
            // btnToggleHook
            // 
            this.btnToggleHook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(227)))), ((int)(((byte)(161)))));
            this.btnToggleHook.FlatAppearance.BorderSize = 0;
            this.btnToggleHook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleHook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnToggleHook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(27)))));
            this.btnToggleHook.Location = new System.Drawing.Point(15, 15);
            this.btnToggleHook.Name = "btnToggleHook";
            this.btnToggleHook.Size = new System.Drawing.Size(250, 45);
            this.btnToggleHook.TabIndex = 0;
            this.btnToggleHook.Text = "START INTERCEPTING";
            this.btnToggleHook.UseVisualStyleBackColor = false;
            this.btnToggleHook.Click += new System.EventHandler(this.btnToggleHook_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.pnlMain.Controls.Add(this.rtxtLogView);
            this.pnlMain.Controls.Add(this.pnlLogHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(280, 75);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMain.Size = new System.Drawing.Size(670, 705);
            this.pnlMain.TabIndex = 2;
            // 
            // rtxtLogView
            // 
            this.rtxtLogView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(27)))));
            this.rtxtLogView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtLogView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtLogView.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxtLogView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.rtxtLogView.Location = new System.Drawing.Point(15, 60);
            this.rtxtLogView.Name = "rtxtLogView";
            this.rtxtLogView.ReadOnly = true;
            this.rtxtLogView.Size = new System.Drawing.Size(640, 630);
            this.rtxtLogView.TabIndex = 1;
            this.rtxtLogView.Text = "";
            // 
            // pnlLogHeader
            // 
            this.pnlLogHeader.Controls.Add(this.btnClearView);
            this.pnlLogHeader.Controls.Add(this.lblLogHeaderTitle);
            this.pnlLogHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogHeader.Location = new System.Drawing.Point(15, 15);
            this.pnlLogHeader.Name = "pnlLogHeader";
            this.pnlLogHeader.Size = new System.Drawing.Size(640, 45);
            this.pnlLogHeader.TabIndex = 0;
            // 
            // btnClearView
            // 
            this.btnClearView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.btnClearView.FlatAppearance.BorderSize = 0;
            this.btnClearView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearView.ForeColor = System.Drawing.Color.White;
            this.btnClearView.Location = new System.Drawing.Point(540, 5);
            this.btnClearView.Name = "btnClearView";
            this.btnClearView.Size = new System.Drawing.Size(100, 30);
            this.btnClearView.TabIndex = 1;
            this.btnClearView.Text = "CLEAR VIEW";
            this.btnClearView.UseVisualStyleBackColor = false;
            this.btnClearView.Click += new System.EventHandler(this.btnClearView_Click);
            // 
            // lblLogHeaderTitle
            // 
            this.lblLogHeaderTitle.AutoSize = true;
            this.lblLogHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.lblLogHeaderTitle.Location = new System.Drawing.Point(0, 10);
            this.lblLogHeaderTitle.Name = "lblLogHeaderTitle";
            this.lblLogHeaderTitle.Size = new System.Drawing.Size(252, 21);
            this.lblLogHeaderTitle.TabIndex = 0;
            this.lblLogHeaderTitle.Text = "REAL-TIME KEYSTREAM STREAM";
            // 
            // timerStats
            // 
            this.timerStats.Interval = 1000;
            this.timerStats.Tick += new System.EventHandler(this.timerStats_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(950, 780);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(850, 780);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keylogger Interceptor - OOP Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.grpEmailSettings.ResumeLayout(false);
            this.grpEmailSettings.PerformLayout();
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlLogHeader.ResumeLayout(false);
            this.pnlLogHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnToggleHook;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.CheckBox chkLogToFile;
        private System.Windows.Forms.CheckBox chkRealtimeView;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox grpEmailSettings;
        private System.Windows.Forms.CheckBox chkLogToEmail;
        private System.Windows.Forms.Label lblSmtpHost;
        private System.Windows.Forms.TextBox txtSmtpHost;
        private System.Windows.Forms.Label lblSmtpPort;
        private System.Windows.Forms.TextBox txtSmtpPort;
        private System.Windows.Forms.CheckBox chkEnableSsl;
        private System.Windows.Forms.Label lblSenderEmail;
        private System.Windows.Forms.TextBox txtSenderEmail;
        private System.Windows.Forms.Label lblSenderPassword;
        private System.Windows.Forms.TextBox txtSenderPassword;
        private System.Windows.Forms.Label lblRecipientEmail;
        private System.Windows.Forms.TextBox txtRecipientEmail;
        private System.Windows.Forms.Label lblEmailNote;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTotalKeys;
        private System.Windows.Forms.Label lblStatusVal;
        private System.Windows.Forms.Label lblElapsedTimeVal;
        private System.Windows.Forms.Label lblActiveAppVal;
        private System.Windows.Forms.Label lblTotalKeysVal;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.Label lblActiveApp;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlLogHeader;
        private System.Windows.Forms.Label lblLogHeaderTitle;
        private System.Windows.Forms.Button btnClearView;
        private System.Windows.Forms.RichTextBox rtxtLogView;
        private System.Windows.Forms.Button btnOpenLog;
        private System.Windows.Forms.Timer timerStats;
    }
}
