using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ChatbotApp.Models;

namespace ChatbotApp.Services
{
    public class GeminiChatService : IChatService
    {
        private readonly string _apiKey;
        private readonly string _modelName;
        private readonly HttpClient _httpClient;

        public GeminiChatService(string apiKey, string modelName)
        {
            _apiKey = apiKey;
            _modelName = modelName;
            _httpClient = new HttpClient();
        }

        public async Task<string> SendMessageAsync(List<ChatMessage> history)
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
            {
                throw new InvalidOperationException("API key cannot be empty. Please configure it in appsettings.json.");
            }

            string url = $"https://generativelanguage.googleapis.com/v1beta/models/{_modelName}:generateContent?key={_apiKey}";

            // Build request body
            var requestBody = new GeminiRequest();
            foreach (var msg in history)
            {
                string apiRole = msg.Role.ToLower() == "user" ? "user" : "model";
                requestBody.contents.Add(new Content
                {
                    role = apiRole,
                    parts = new List<Part> { new Part { text = msg.Text } }
                });
            }

            var jsonOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                IgnoreReadOnlyProperties = true
            };

            string jsonPayload = JsonSerializer.Serialize(requestBody, jsonOptions);
            var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _httpClient.PostAsync(url, content);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException($"API request failed with status code {response.StatusCode}. Details: {errorContent}");
                }

                string jsonResponse = await response.Content.ReadAsStringAsync();
                var geminiResponse = JsonSerializer.Deserialize<GeminiResponse>(jsonResponse, jsonOptions);

                var responseText = geminiResponse?.candidates?[0]?.content?.parts?[0]?.text;
                if (string.IsNullOrEmpty(responseText))
                {
                    throw new Exception("Received empty response from Gemini API.");
                }

                return responseText;
            }
            catch (Exception ex)
            {
                throw new Exception($"Gemini API error: {ex.Message}", ex);
            }
        }

        #region Internal API Request/Response Models
        private class GeminiRequest
        {
            public List<Content> contents { get; set; } = new();
        }

        private class Content
        {
            public string role { get; set; } = string.Empty;
            public List<Part> parts { get; set; } = new();
        }

        private class Part
        {
            public string text { get; set; } = string.Empty;
        }

        private class GeminiResponse
        {
            public List<Candidate>? candidates { get; set; }
        }

        private class Candidate
        {
            public Content? content { get; set; }
            public string? finishReason { get; set; }
        }
        #endregion
    }
}
