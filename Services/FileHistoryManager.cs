using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ChatbotApp.Models;

namespace ChatbotApp.Services
{
    public class FileHistoryManager : IHistoryManager
    {
        private readonly string _filePath;

        public FileHistoryManager(string filePath)
        {
            _filePath = filePath;
        }

        public void SaveHistory(List<ChatMessage> history)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(history, options);
                File.WriteAllText(_filePath, jsonString);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[Error Saving History] {ex.Message}");
                Console.ResetColor();
            }
        }

        public List<ChatMessage> LoadHistory()
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    return new List<ChatMessage>();
                }

                string jsonString = File.ReadAllText(_filePath);
                var history = JsonSerializer.Deserialize<List<ChatMessage>>(jsonString);
                return history ?? new List<ChatMessage>();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[Error Loading History] {ex.Message}");
                Console.ResetColor();
                return new List<ChatMessage>();
            }
        }
    }
}
