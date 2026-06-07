using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ChatbotApp.Services;

namespace ChatbotApp.Models
{
    public class ChatSession
    {
        private readonly IChatService _chatService;
        private readonly IHistoryManager _historyManager;
        private readonly List<ChatMessage> _history;

        public ChatSession(IChatService chatService, IHistoryManager historyManager)
        {
            _chatService = chatService ?? throw new ArgumentNullException(nameof(chatService));
            _historyManager = historyManager ?? throw new ArgumentNullException(nameof(historyManager));
            _history = new List<ChatMessage>();
        }

        public List<ChatMessage> GetHistory()
        {
            return new List<ChatMessage>(_history);
        }

        public void LoadHistory()
        {
            _history.Clear();
            var savedHistory = _historyManager.LoadHistory();
            if (savedHistory != null)
            {
                _history.AddRange(savedHistory);
            }
        }

        public async Task<string> SendUserMessageAsync(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Message cannot be empty or whitespace.", nameof(text));
            }

            var userMessage = new ChatMessage("user", text);
            _history.Add(userMessage);
            _historyManager.SaveHistory(_history);

            try
            {
                string replyText = await _chatService.SendMessageAsync(_history);

                var botMessage = new ChatMessage("model", replyText);
                _history.Add(botMessage);
                _historyManager.SaveHistory(_history);

                return replyText;
            }
            catch
            {
                // Rollback if transmission fails so history isn't corrupted
                _history.Remove(userMessage);
                _historyManager.SaveHistory(_history);
                throw;
            }
        }

        public void ClearHistory()
        {
            _history.Clear();
            _historyManager.SaveHistory(_history);
        }
    }
}
