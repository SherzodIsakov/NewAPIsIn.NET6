
//Используется для завершение не неотменяемых задач.
//Выдается «TimeoutException», когда истекает тайм-аут операции.

Task operationTask = DoSomethingLongAsync();

await operationTask.WaitAsync(TimeSpan.FromSeconds(5));

async Task DoSomethingLongAsync()
{
    Console.WriteLine("DoSomethingLongAsync started.");
    await Task.Delay(TimeSpan.FromSeconds(10));
    Console.WriteLine("DoSomethingLongAsync ended.");
}

Console.ReadKey();

// Output:
// DoSomethingLongAsync started.
// Unhandled exception.System.TimeoutException: The operation has timed out.

