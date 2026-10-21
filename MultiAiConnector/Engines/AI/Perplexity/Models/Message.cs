namespace MultiAiConnector.Engines.AI.Perplexity.Models;

/// <summary>
/// Represents a message within the Perplexity AI context.
/// </summary>
public class Message
{
    /// <summary>
    /// Indicates the role of the message sender. Common values could be "user" or "assistant" (bot).
    /// </summary>
    public string role { get; set; }

    /// <summary>
    /// Stores the textual content of the message.
    /// </summary>
    public string content { get; set; }
}