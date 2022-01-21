// Порядок следования полей при сериализации
// С помощью специального атрибута JsonPropertyOrder теперь можно управлять порядком,
// в котором сериализованные поля будут помещаться в итоговый JSON:

using System.Text.Json.Serialization;

public class Person
{
    public string City { get; set; } // No order defined (has the default ordering value of 0)

    [JsonPropertyOrder(1)] // Serialize after other properties that have default ordering
    public string FirstName { get; set; }

    [JsonPropertyOrder(2)] // Serialize after FirstName
    public string LastName { get; set; }

    [JsonPropertyOrder(-1)] // Serialize before other properties that have default ordering
    public int Id { get; set; }
}
