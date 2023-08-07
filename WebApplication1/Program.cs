using WebApplication1;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

builder.Services.AddSingleton<ICalendarService, CalendarService>();
builder.Services.AddSingleton<ISystemClock, SystemClock>();

app.Run();