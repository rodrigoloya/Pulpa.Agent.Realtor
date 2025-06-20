using System.Runtime.InteropServices;
using Microsoft.AspNetCore.SignalR;
using Pulpa.Agent.Realtor.Domain.DTO;

namespace Pulpa.Agent.Realtor.Services
{
    public class OpenAiService
    {
        private readonly OpenAiResponse _openAiResponse;
        private readonly HttpClient _httpClient;

        public OpenAiService(HttpClient httpClient, ILogger logger)
        {
           
            _httpClient = httpClient;
        }

        private async Task<string> GetAIResponse(string input)
        {
            var response = await _httpClient.PostAsJsonAsync("https://api.openai.com/v1/completions", new
            {
                prompt = input,
                model = "text-davinci-003",
                max_tokens = 100
            });

            var result = await response.Content.ReadFromJsonAsync<OpenAiResponse>();
            return result?.Choices.FirstOrDefault()?.Text ?? "Sorry, I couldn't process that.";
        }

    }

    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }


     
}
