using System.Text.Json;

namespace MultiAiConnector.Engines.Core;

public interface IAiRequesterByPrompts
{
    public Task<string> RunRequest(string prompt);
}

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);