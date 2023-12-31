namespace SystemClock.Web;

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