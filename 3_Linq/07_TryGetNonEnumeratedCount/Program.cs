// Новый метод TryGetNonEnumeratedCount() сильно помогает в случаях, когда надо узнать количество элементов коллекции без её перебора:

IEnumerable<int> numbers = GetNumbers();
TryGetNonEnumeratedCount(numbers);
// Output: Could not get a count of numbers without enumerating the sequence 

IEnumerable<int> enumeratedNumbers = numbers.ToList();

var test = enumeratedNumbers.ElementAt(-1);

TryGetNonEnumeratedCount(enumeratedNumbers);
// Output: Count: 5

void TryGetNonEnumeratedCount(IEnumerable<int> numbers)
{
    if (numbers.TryGetNonEnumeratedCount(out int count))
        Console.WriteLine($"Count: {count}");
    else
        Console.WriteLine("Could not get a count of numbers without enumerating the sequence");
}

IEnumerable<int> GetNumbers()
{
    yield return 1;
    yield return 2;
    yield return 3;
    yield return 4;
    yield return 5;
}

