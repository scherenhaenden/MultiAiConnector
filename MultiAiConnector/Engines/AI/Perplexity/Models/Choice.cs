namespace MultiAiConnector.Engines.Core;

public class Choice
{
    public int index { get; set; }
    public string finish_reason { get; set; }
    public Message message { get; set; }
    public Delta delta { get; set; }
}