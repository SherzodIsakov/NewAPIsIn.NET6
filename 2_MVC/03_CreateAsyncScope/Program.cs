// � .NET 6 ����������� ����� ����� CreateAsyncScope ��� �������� AsyncServiceScope.
// ����� CreateScope ������� ���������� ��� �������� ������ IAsyncDisposable.

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


