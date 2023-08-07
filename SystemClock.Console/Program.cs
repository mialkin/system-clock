using SystemClock.Console;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

builder.Services.AddSingleton<ICalendarService, CalendarService>();
builder.Services.AddSingleton<ISystemClock, SystemClock.Console.SystemClock>();

app.Run();