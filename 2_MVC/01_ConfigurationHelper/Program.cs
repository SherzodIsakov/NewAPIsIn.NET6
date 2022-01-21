
//GetRequiredSection выдает исключение, если необходимый раздел конфигурации отсутствует.

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

MySettings mySettings = new();

// Throws InvalidOperationException if a required section of configuration is missing
app.Configuration
    .GetRequiredSection("MySettings")
    .Bind(mySettings);

app.Run();

class MySettings
{
    public string? SettingValue { get; set; }
}