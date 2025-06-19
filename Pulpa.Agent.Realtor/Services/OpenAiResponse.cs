 

namespace Pulpa.Agent.Realtor.Services
{
    public class Choice
    {
        public string Text { get; set; }
    }

    public class OpenAiResponse
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger _logger;

        public OpenAiResponse(HttpClient httpClient, ILogger logger)
        {
            this._httpClient = httpClient;
            _logger = logger;
        }
        public List<Choice> Choices { get; set; }
       

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
}
