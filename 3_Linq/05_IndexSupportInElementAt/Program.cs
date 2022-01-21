// В .NET Core 3.0 представлена структура Index,
// которая используется компилятором C# для поддержки нового унарного префиксного оператора (^).
// Имеется в виду индекс "с конца" коллекции.
// Для Enumerable.ElementAt добавлена поддержка Index .

IEnumerable<int> source = new int[] { 1, 2, 3, 4, 5 };
int last = source.ElementAt(^0);
Console.WriteLine(last); // 5

Enumerable.Range(1, 10).ElementAt(^2); // 9

source.Take(..3);    // вместо source.Take(3)
source.Take(3..);    // вместо source.Skip(3)
source.Take(2..7);   // вместо source.Take(7).Skip(2)
source.Take(^3..);   // вместо source.TakeLast(3)
source.Take(..^3);   // вместо source.SkipLast(3)
source.Take(^7..^3); // вместо source.TakeLast(7).SkipLast(3).

