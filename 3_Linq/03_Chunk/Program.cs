// Если вам нужно разбить элементы последовательности на фрагменты,
// вам больше не нужно реализовывать это самостоятельно в .NET 6.
// Он представляет новый метод расширения Enumerable.Chunk .

IEnumerable<int> numbers = Enumerable.Range(1, 505);
IEnumerable<int[]> chunks = numbers.Chunk(100);

foreach (int[] chunk in chunks)
{
    Console.WriteLine($"{chunk.First()}...{chunk.Last()}");
}

//  Output:
//  1...100
//  101...200
//  201...300
//  301...400
//  401...500
//  501...505

