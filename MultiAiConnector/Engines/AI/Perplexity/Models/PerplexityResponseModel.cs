namespace MultiAiConnector.Engines.Core;

public class PerplexityResponseModel
{
    public string id { get; set; }
    public string model { get; set; }
    public int created { get; set; }
    public Usage usage { get; set; }
    public string @object { get; set; }
    public List<Choice> choices { get; set; }
}