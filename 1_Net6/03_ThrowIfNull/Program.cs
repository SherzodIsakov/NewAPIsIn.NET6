// Нет необходимости проверять значение null в каждом методе, прежде чем создавать исключение

ExampleMethod(null);

void ExampleMethod(object param)
{
    ArgumentNullException.ThrowIfNull(param);
}

Console.ReadKey();