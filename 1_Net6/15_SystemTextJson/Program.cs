// Игнор цикличных ссылок
// Сериализатор заменяет ссылку на null, а не игнорирует свойство полностью.

using System.Text.Json;
using System.Text.Json.Serialization;

void Test()
{
    var node = new Node { Description = "Node 1" };
    node.Next = node;

    var opts = new JsonSerializerOptions { ReferenceHandler = ReferenceHandler.IgnoreCycles };

    string json = JsonSerializer.Serialize(node, opts);
    Console.WriteLine(json); 
    
    // Prints {"Description":"Node 1","Next":null}
}

class Node
{
    public string Description { get; set; }
    public object Next { get; set; }
}
