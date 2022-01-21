// В.NET 6 метод Enumerable.Take поддерживает Range.

IEnumerable<int> numbers = new int[] { 1, 2, 3, 4, 5 };

IEnumerable<int> taken1 = numbers.Take(2..4);
foreach (int i in taken1)
    Console.WriteLine(i);
// Output:
// 3
// 4

IEnumerable<int> taken2 = numbers.Take(..3);
foreach (int i in taken2)
    Console.WriteLine(i);
// Output:
// 1
// 2
// 3

IEnumerable<int> taken3 = numbers.Take(3..);
foreach (int i in taken3)
    Console.WriteLine(i);
// Output:
// 4
// 5


//В метод Take() добавили перегрузку:

numbers.Take(..3);       // вместо numbers.Take(3)
numbers.Take(3..);       // вместо numbers.Skip(3)
numbers.Take(2..7);      // вместо numbers.Take(7).Skip(2)
numbers.Take(^3..);      // вместо numbers.TakeLast(3)
numbers.Take(..^3);      // вместо numbers.SkipLast(3)
numbers.Take(^7..^3);    // вместо numbers.TakeLast(7).SkipLast(3)