//Поддержка IAsyncEnumerable<T>

//Сериализатор System.Text.Json теперь поддерживает IAsyncEnumerable<T>
//При сериализации он их превращает в массивы:

using System.Text.Json;

static async IAsyncEnumerable<int> PrintNumbers(int n)
{
	for (int i = 0; i < n; i++) yield return i;
}

using Stream stream = Console.OpenStandardOutput();
var data = new { Data = PrintNumbers(3) };
await JsonSerializer.SerializeAsync(stream, data); 

// prints {"Data":[0,1,2]}

