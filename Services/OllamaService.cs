using OllamaSharp;
using Microsoft.Extensions.AI;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Virtual_intelligent_assistant.Services
{
    public class OllamaService
    {
        private readonly IChatClient _client;
        private readonly List<ChatMessage> _chatHistory = new List<ChatMessage>();

        public OllamaService()
        {
            _client = new OllamaApiClient(new Uri("http://localhost:11434/"), "huihui_ai/jan-nano-abliterated:latest");
        }

        public async Task<string> GetResponseAsync(string userInput)
        {
            _chatHistory.Add(new ChatMessage(ChatRole.User, userInput));

            string response = "";
            await foreach (var update in _client.GetStreamingResponseAsync(_chatHistory))
            {
                response += update.Text;
            }

            _chatHistory.Add(new ChatMessage(ChatRole.Assistant, response));

            return response;
        }
    }
}
