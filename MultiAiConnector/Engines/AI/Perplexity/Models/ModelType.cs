using MultiAiConnector.SystemExtender.Attributes;

namespace MultiAiConnector.Engines.Perplexity;

public enum ModelType
{
    [StringValue("sonar-small-chat")]
    SonarSmallChat,

    [StringValue("sonar-small-online")]
    SonarSmallOnline,

    [StringValue("sonar-medium-chat")]
    SonarMediumChat,

    [StringValue("sonar-medium-online")]
    SonarMediumOnline,

    [StringValue("codelama-70b-instruct")]
    CodelLama70bInstruct,

    [StringValue("mistral-7b-instruct")]
    Mistral7bInstruct,

    [StringValue("mistral-8x7b-instruct")]
    Mistral8x7bInstruct
}