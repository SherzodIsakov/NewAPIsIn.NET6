﻿// .NET 6 представлены новые типы: JsonArray, JsonNode, JsonObject, JsonValue
// для обработки записываемой в памяти объектной модели документа (DOM)
// для произвольного доступа к элементам JSON в структурированном представлении данных.

using System.Text.Json.Nodes;

// Parse a JSON object
JsonNode jNode = JsonNode.Parse("{\"Value\":\"Text\",\"Array\":[1,5,13,17,2]}");
string value = (string)jNode["Value"];
Console.WriteLine(value); // Text
                          // or
value = jNode["Value"].GetValue<string>();
Console.WriteLine(value); // Text

int arrayItem = jNode["Array"][1].GetValue<int>();
Console.WriteLine(arrayItem); // 5
                              // or
arrayItem = (int)jNode["Array"][1];
Console.WriteLine(arrayItem); // 5

// Create a new JsonObject
var jObject = new JsonObject
{
    ["Value"] = "Text",
    ["Array"] = new JsonArray(1, 5, 13, 17, 2)
};
Console.WriteLine(jObject["Value"].GetValue<string>());  // Text
Console.WriteLine(jObject["Array"][1].GetValue<int>());  // 5

// Converts the current instance to string in JSON format
string json = jObject.ToJsonString();
Console.WriteLine(json); // {"Value":"Text","Array":[1,5,13,17,2]}

