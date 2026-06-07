using System.Collections.Generic;
using System.Threading.Tasks;
using ChatbotApp.Models;

namespace ChatbotApp.Services
{
    public interface IChatService
    {
        Task<string> SendMessageAsync(List<ChatMessage> history);
    }
}
