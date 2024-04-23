using MultiAiConnector.Engines.Core;
using Newtonsoft.Json;

namespace MultiAiConnector.Engines.Perplexity;

public class RequestModel
{
    [JsonProperty("model")]
    public ModelType model { get; set; }
    public List<Message> messages { get; set; }
}