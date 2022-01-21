
// Они представляют часть даты или времени DateTime .

DateOnly dateOnly = new(2022, 1, 1);
Console.WriteLine(dateOnly);
// Output: 01.01.2022

TimeOnly timeOnly = new(19, 0, 0);
Console.WriteLine(timeOnly);
// Output: 19:00

DateOnly dateOnlyFromDate = DateOnly.FromDateTime(DateTime.Now);
Console.WriteLine(dateOnlyFromDate);
// Output: 26.01.2022

TimeOnly timeOnlyFromDate = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine(timeOnlyFromDate);
// Output: 16:05

Console.ReadKey();