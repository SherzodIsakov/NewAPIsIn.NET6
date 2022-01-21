// В .NET 6 представлен новый метод CreateAsyncScope для создания AsyncServiceScope.
// Метод CreateScope создает исключение при удалении службы IAsyncDisposable.

await using var provider = new ServiceCollection()
        .AddScoped<Example>()
        .BuildServiceProvider();

await using (var scope = provider.CreateAsyncScope())
{
    var example = scope.ServiceProvider.GetRequiredService<Example>();
}

class Example : IAsyncDisposable
{
    public ValueTask DisposeAsync() => default;
}


