
// Полностью асинхронный PeriodicTimer.
// Позволяет асинхронно ждать тиков таймера.
// У него есть один метод, «WaitForNextTickAsync»,
// который ожидает следующего такта таймера или остановки таймера.


using PeriodicTimer timer = new(TimeSpan.FromSeconds(1));

while (await timer.WaitForNextTickAsync())
{
    Console.WriteLine(DateTime.UtcNow);
}

Console.ReadKey();
// Output:
// 20.01.2022 4:59:30
// 20.01.2022 4:59:31
// 20.01.2022 4:59:32
// 20.01.2022 4:59:33
// 20.01.2022 4:59:34
// 20.01.2022 4:59:35
// 20.01.2022 4:59:36
//...