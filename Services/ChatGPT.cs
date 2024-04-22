namespace Services.ChatGPT;
public class OpenAIClient
{
    public async Task<string> GetResponse(string? prompt)
    {
        string? apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
        var api = new OpenAI_API.OpenAIAPI(apiKey);
        var  chat = api.Chat.CreateConversation();
        chat.AppendSystemMessage("Result by format json");
        chat.AppendSystemMessage("Give me list 12  music for about");
        chat.AppendUserInput(prompt);

        return await chat.GetResponseFromChatbotAsync();
    }
}