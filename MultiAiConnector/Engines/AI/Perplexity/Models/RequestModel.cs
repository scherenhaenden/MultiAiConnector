using Newtonsoft.Json;

namespace MultiAiConnector.Engines.AI.Perplexity.Models;

public class RequestModel
{
    [JsonProperty("model")]
    public ModelType model { get; set; }
    public List<Message> messages { get; set; }
}