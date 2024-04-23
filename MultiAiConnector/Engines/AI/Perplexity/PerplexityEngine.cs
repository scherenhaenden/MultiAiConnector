using MultiAiConnector.Engines.Core;
using MultiAiConnector.Engines.Perplexity;
using MultiAiConnector.SystemExtender.Attributes;
using Newtonsoft.Json;

namespace MultiAiConnector.Engines.AI.Perplexity;

public class PerplexityEngine: IAiRequesterByPrompts
{
    private readonly string _token;

    public PerplexityEngine(string token)
    {
        _token = token;
    }
    
    public async Task<string> RunRequest(string prompt)
    {
        
        RequestModel requestModel = new RequestModel();
        var messages = new List<Message>();
        messages.Add(new Message { role = "system", content = "Be precise and concise." });
        messages.Add(new Message { role = "user", content = prompt });
        requestModel.model = ModelType.SonarMediumOnline;
        requestModel.messages = messages;
        
        var settings = new JsonSerializerSettings();
        settings.Converters.Add(new StringValueEnumConverter());
        var serialized = JsonConvert.SerializeObject(requestModel, settings);
        
        
   


        //var token = "Bearer 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";

        var response = await FluentRestRequester.Create()
            .BaseAddress("https://api.perplexity.ai/")
            .Endpoint("chat/completions")
            .WithMethod(HttpMethod.Post)
            .WithHeader("accept", "application/json")
            //.WithHeader("Content-Type", "application/json")
            .WithContentType("application/json")
            .WithHeader("authorization", _token)
            .WithPayloadModel(serialized)
            .SendAsync<PerplexityResponseModel>();

        if (response is not null)
        {
            var results = response.choices.Select(x => x.message.content).ToList();
            return string.Join(Environment.NewLine, results);
        }

        return "";
    }
}