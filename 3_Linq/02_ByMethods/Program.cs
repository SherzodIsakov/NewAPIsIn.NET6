
// Новые методы позволяют явно указывать поле-селектор MinBy, MaxBy, DistinctBy, ExceptBy, IntersectBy, UnionBy

List<Product> products = new()
{
    new() { Name = "Product1", Price = 100 },
    new() { Name = "Product2", Price = 5 },
    new() { Name = "Product3", Price = 50 },
};

Product theCheapestProduct = products.MinBy(x => x.Price);
Console.WriteLine(theCheapestProduct);
// Output: Product { Name = Product2, Price = 5 }

Product theMostExpensiveProduct = products.MaxBy(x => x.Price);
Console.WriteLine(theMostExpensiveProduct);
// Output: Product { Name = Product1, Price = 100 }

Console.ReadKey();

record Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

