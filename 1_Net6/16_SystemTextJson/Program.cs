// Серилизация и Десериализация в/из Stream

using System.Text;
using System.Text.Json;

string json = "{\"Value\":\"Deserialized from stream\"}";
byte[] bytes = Encoding.UTF8.GetBytes(json);

// Deserialize from stream
using MemoryStream ms = new MemoryStream(bytes);
Example desializedExample = JsonSerializer.Deserialize<Example>(ms);
Console.WriteLine(desializedExample.Value);

// ==================================================================

// Serialize to stream
JsonSerializerOptions options = new() { WriteIndented = true };
using Stream outputStream = Console.OpenStandardOutput();
Example exampleToSerialize = new() { Value = "Serialized from stream" };
JsonSerializer.Serialize<Example>(outputStream, exampleToSerialize, options);

class Example
{
    public string Value { get; set; }
}
