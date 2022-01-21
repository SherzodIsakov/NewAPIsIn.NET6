//Методы FirstOrDefault/LastOrDefault/SingleOrDefault позволяют указывать дефолтное значение

List<int> list1 = new() { 1, 2, 3 };
int item1 = list1.FirstOrDefault(i => i == 4, -1);
Console.WriteLine(item1); // -1

List<string> list2 = new() { "Item1" };
string item2 = list2.SingleOrDefault(i => i == "Item2", "Not found");
Console.WriteLine(item2); // Not found

