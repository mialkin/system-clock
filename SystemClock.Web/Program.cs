using SystemClock.Web;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
services.AddSingleton<ICalendarService, CalendarService>();
services.AddSingleton<ISystemClock, SystemClock.Web.SystemClock>();

var app = builder.Build();
app.MapGet("/", () => "Hello World!");

app.Run();