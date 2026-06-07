using System.Collections.Generic;
using ChatbotApp.Models;

namespace ChatbotApp.Services
{
    public interface IHistoryManager
    {
        void SaveHistory(List<ChatMessage> history);
        List<ChatMessage> LoadHistory();
    }
}
