namespace SystemClock.Console;

public class CalendarService : ICalendarService
{
    private readonly ISystemClock _systemClock;

    public CalendarService(ISystemClock systemClock) => _systemClock = systemClock;

    public bool IsWorkingDay()
    {
        switch (_systemClock.Now.DayOfWeek)
        {
            case DayOfWeek.Saturday:
            case DayOfWeek.Sunday:
                return false;
            default:
                return true;
        }
    }
}

public interface ISystemClock
{
    DateTime Now { get; }
}

public class SystemClock : ISystemClock
{
    public DateTime Now => DateTime.Now;
}