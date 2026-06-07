using System;
using System.IO;
using System.Text.Json;

namespace ChatbotApp.Helpers
{
    public class GeminiConfig
    {
        public string ApiKey { get; set; } = string.Empty;
        public string ModelName { get; set; } = "gemini-flash-latest";
    }

    public class AppSettings
    {
        public GeminiConfig Gemini { get; set; } = new();
    }

    public static class ConfigManager
    {
        private const string ConfigPath = "appsettings.json";

        public static AppSettings LoadSettings()
        {
            try
            {
                if (!File.Exists(ConfigPath))
                {
                    var defaultSettings = new AppSettings();
                    SaveSettings(defaultSettings);
                    return defaultSettings;
                }

                string json = File.ReadAllText(ConfigPath);
                var settings = JsonSerializer.Deserialize<AppSettings>(json);
                return settings ?? new AppSettings();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[Config Load Error] {ex.Message}. Using default settings.");
                Console.ResetColor();
                return new AppSettings();
            }
        }

        public static void SaveSettings(AppSettings settings)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(settings, options);
                File.WriteAllText(ConfigPath, json);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[Config Save Error] {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}
