
// Метод Zip теперь имеет перегрузку для итерации по трём коллекциям.

int[] numbers = { 1, 2, 3, 4, };
string[] months = { "Jan", "Feb", "Mar" };
string[] seasons = { "Winter", "Winter", "Spring" };

var test = numbers.Zip(months).Zip(seasons);

foreach ((int, string, string) zipped in numbers.Zip(months, seasons))
{
    Console.WriteLine($"{zipped.Item1} {zipped.Item2} {zipped.Item3}");
}
// Output:
// 1 Jan Winter
// 2 Feb Winter
// 3 Mar Spring
