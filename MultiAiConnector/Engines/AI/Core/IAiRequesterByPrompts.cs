namespace MultiAiConnector.Engines.AI.Core;

public interface IAiRequesterByPrompts
{
    public Task<string> RunRequest(string prompt);
}

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);