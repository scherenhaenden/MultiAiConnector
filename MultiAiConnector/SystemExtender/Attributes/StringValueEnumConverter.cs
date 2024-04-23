using System.Reflection;
using Newtonsoft.Json;

namespace MultiAiConnector.SystemExtender.Attributes;

public class StringValueEnumConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return objectType.IsEnum;
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        string enumText = reader.Value.ToString();
        foreach (var name in Enum.GetNames(objectType))
        {
            FieldInfo field = objectType.GetField(name);
            var attr = Attribute.GetCustomAttribute(field, typeof(StringValueAttribute)) as StringValueAttribute;
            if (attr != null && attr.Value == enumText)
                return Enum.Parse(objectType, name);
        }
        throw new JsonSerializationException($"Unable to parse '{enumText}' to enum {objectType.Name}.");
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        Type type = value.GetType();
        FieldInfo fieldInfo = type.GetField(value.ToString());
        var attr = Attribute.GetCustomAttribute(fieldInfo, typeof(StringValueAttribute)) as StringValueAttribute;
        if (attr != null)
        {
            writer.WriteValue(attr.Value);
        }
        else
        {
            writer.WriteValue(value.ToString());
        }
    }
}