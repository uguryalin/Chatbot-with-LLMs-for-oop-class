using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ChatbotApp.Helpers;
using ChatbotApp.Models;
using ChatbotApp.Services;

namespace ChatbotApp
{
    class Program
    {
        private static AppSettings _settings = null!;
        private static IChatService _chatService = null!;
        private static IHistoryManager _historyManager = null!;
        private static ChatSession _chatSession = null!;

        static async Task Main(string[] args)
        {
            // Set UTF-8 encoding for Turkish and special characters
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            // Load settings
            _settings = ConfigManager.LoadSettings();

            // Initialize services (Dependency Injection / Polymorphism)
            _historyManager = new FileHistoryManager("chat_history.json");
            _chatService = new GeminiChatService(_settings.Gemini.ApiKey, _settings.Gemini.ModelName);
            _chatSession = new ChatSession(_chatService, _historyManager);

            bool exit = false;
            while (!exit)
            {
                ShowHeader();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" [1] Yeni Sohbet Başlat");
                Console.WriteLine(" [2] Önceki Sohbete Devam Et");
                Console.WriteLine(" [3] Sohbet Geçmişini Temizle");
                Console.WriteLine(" [4] Ayarlar / API Anahtarını Değiştir");
                Console.WriteLine(" [5] OOP Yapısını İncele (Proje Detayları)");
                Console.WriteLine(" [6] Çıkış");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" Seçiminiz: ");
                Console.ResetColor();

                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        _chatSession.ClearHistory();
                        await RunChatLoopAsync();
                        break;
                    case "2":
                        _chatSession.LoadHistory();
                        await RunChatLoopAsync();
                        break;
                    case "3":
                        _chatSession.ClearHistory();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n [✔] Sohbet geçmişi başarıyla temizlendi!");
                        Console.ResetColor();
                        Console.WriteLine(" Devam etmek için bir tuşa basın...");
                        Console.ReadKey();
                        break;
                    case "4":
                        ShowSettingsMenu();
                        break;
                    case "5":
                        ShowOopDetails();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n [!] Geçersiz seçim. Devam etmek için bir tuşa basın...");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void ShowHeader()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==================================================================");
            Console.WriteLine("         Gemini AI Destekli OOP Konsol Chatbot Uygulaması         ");
            Console.WriteLine("==================================================================");
            Console.ResetColor();
            
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($" Model: {_settings.Gemini.ModelName} | Geçmiş Dosyası: chat_history.json");
            Console.WriteLine("==================================================================");
            Console.ResetColor();
        }

        private static async Task RunChatLoopAsync()
        {
            Console.Clear();
            ShowHeader();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Sohbet Başlatıldı! Geri dönmek için 'exit' veya 'çıkış' yazın.");
            Console.WriteLine("==================================================================");
            Console.ResetColor();

            // Print existing history if any
            var history = _chatSession.GetHistory();
            foreach (var message in history)
            {
                if (message.Role.ToLower() == "user")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"\n[Siz - {message.Timestamp:HH:mm:ss}]: ");
                    Console.ResetColor();
                    Console.WriteLine(message.Text);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"\n[Gemini - {message.Timestamp:HH:mm:ss}]: ");
                    Console.ResetColor();
                    Console.WriteLine(message.Text);
                }
            }

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n[Siz]: ");
                Console.ResetColor();
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input)) continue;

                if (input.Trim().ToLower() == "exit" || input.Trim().ToLower() == "çıkış")
                {
                    break;
                }

                try
                {
                    string reply = await CallApiWithLoadingAnimation(async () =>
                    {
                        return await _chatSession.SendUserMessageAsync(input);
                    });

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"\n[Gemini - {DateTime.Now:HH:mm:ss}]: ");
                    Console.ResetColor();
                    
                    // Premium typewriter effect
                    Typewrite(reply, ConsoleColor.Cyan, 5);
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n[!] Hata Oluştu: {ex.Message}");
                    Console.ResetColor();
                }
            }
        }

        private static async Task<string> CallApiWithLoadingAnimation(Func<Task<string>> apiCall)
        {
            var cts = new CancellationTokenSource();
            var spinnerTask = Task.Run(async () =>
            {
                string[] spinner = { "|", "/", "-", "\\" };
                int counter = 0;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n Gemini düşünüyor... ");
                while (!cts.IsCancellationRequested)
                {
                    Console.Write(spinner[counter % 4]);
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    counter++;
                    await Task.Delay(100);
                }
                // Clear spinner
                Console.Write(" \r");
                Console.ResetColor();
            });

            try
            {
                string response = await apiCall();
                cts.Cancel();
                await spinnerTask;
                return response;
            }
            catch
            {
                cts.Cancel();
                try { await spinnerTask; } catch { }
                throw;
            }
        }

        private static void Typewrite(string text, ConsoleColor color, int delayMs)
        {
            Console.ForegroundColor = color;
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delayMs);
            }
            Console.ResetColor();
        }

        private static void ShowSettingsMenu()
        {
            ShowHeader();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" AYARLAR");
            Console.WriteLine("==================================================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" Mevcut API Anahtarı: {MaskApiKey(_settings.Gemini.ApiKey)}");
            Console.WriteLine($" Mevcut Model       : {_settings.Gemini.ModelName}");
            Console.WriteLine();
            Console.WriteLine(" [1] API Anahtarını Güncelle");
            Console.WriteLine(" [2] Model Adını Değiştir");
            Console.WriteLine(" [3] Geri Dön");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" Seçiminiz: ");
            Console.ResetColor();

            string? choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Write("\nYeni Gemini API Anahtarını Girin: ");
                string? newKey = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newKey))
                {
                    _settings.Gemini.ApiKey = newKey.Trim();
                    ConfigManager.SaveSettings(_settings);
                    // Reinitialize services
                    _chatService = new GeminiChatService(_settings.Gemini.ApiKey, _settings.Gemini.ModelName);
                    _chatSession = new ChatSession(_chatService, _historyManager);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n[✔] API Anahtarı güncellendi ve appsettings.json dosyasına kaydedildi!");
                    Console.ResetColor();
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("\nYapay Zeka Modelini Seçin:");
                Console.WriteLine(" [1] gemini-flash-latest (Önerilen - Ücretsiz, En Kararlı & Hızlı)");
                Console.WriteLine(" [2] gemini-2.5-flash (Yeni model - Aşırı yoğunlukta 503 verebilir)");
                Console.WriteLine(" [3] gemini-2.5-pro (En Gelişmiş Model)");
                Console.Write("\nSeçiminiz: ");
                string? modelChoice = Console.ReadLine();
                string selectedModel = modelChoice switch
                {
                    "1" => "gemini-flash-latest",
                    "2" => "gemini-2.5-flash",
                    "3" => "gemini-2.5-pro",
                    _ => _settings.Gemini.ModelName
                };

                _settings.Gemini.ModelName = selectedModel;
                ConfigManager.SaveSettings(_settings);
                // Reinitialize services
                _chatService = new GeminiChatService(_settings.Gemini.ApiKey, _settings.Gemini.ModelName);
                _chatSession = new ChatSession(_chatService, _historyManager);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n[✔] Model {selectedModel} olarak güncellendi!");
                Console.ResetColor();
            }

            Console.WriteLine("\nDevam etmek için bir tuşa basın...");
            Console.ReadKey();
        }

        private static string MaskApiKey(string key)
        {
            if (string.IsNullOrWhiteSpace(key)) return "Tanımlanmamış";
            if (key.Length <= 8) return "****";
            return key.Substring(0, 4) + "..." + key.Substring(key.Length - 4);
        }

        private static void ShowOopDetails()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("==================================================================");
            Console.WriteLine("                  PROJEDE UYGULANAN OOP PRENSİPLERİ               ");
            Console.WriteLine("==================================================================");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. SOYUTLAMA (Abstraction):");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   - 'IChatService' ve 'IHistoryManager' arayüzleri (interface) tanımlandı.");
            Console.WriteLine("   - Bu arayüzler, arka plandaki işlemlerin (Gemini API çağrıları veya dosya yazma)");
            Console.WriteLine("     nasıl yapıldığını gizleyerek sadece 'ne yapıldığını' tanımlar.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("2. KAPSÜLLEME (Encapsulation):");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   - 'ChatSession' sınıfı sohbet geçmişini ve durumunu kendi içinde korur.");
            Console.WriteLine("   - Geçmiş mesaj listesine doğrudan dışarıdan ekleme/silme yapılamaz;");
            Console.WriteLine("     'SendUserMessageAsync' veya 'ClearHistory' metodları üzerinden kontrollü değiştirilir.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("3. ÇOK BİÇİMLİLİK VE BAĞIMLILIKLARIN TERSİNE ÇEVRİLMESİ (Polymorphism & DI):");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   - 'ChatSession' sınıfı somut sınıflara değil arayüzlere bağımlıdır.");
            Console.WriteLine("   - Constructor'ında 'IChatService' ve 'IHistoryManager' alır (Dependency Injection).");
            Console.WriteLine("   - Böylece istenirse GeminiChatService yerine MockChatService veya");
            Console.WriteLine("     FileHistoryManager yerine DatabaseHistoryManager kolayca takılabilir.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("4. DOSYA İŞLEMLERİ VE SERİLEŞTİRME (File I/O & Serialization):");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   - 'FileHistoryManager' sınıfı sohbet verilerini 'System.Text.Json' kullanarak");
            Console.WriteLine("     diske JSON olarak serileştirip yazar ve geri yükler.");
            Console.ResetColor();
            Console.WriteLine("==================================================================");
            Console.WriteLine("\nMenüye dönmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
