namespace SystemClock.Web;

public class SystemClock : ISystemClock
{
    public DateTime Now => DateTime.Now;
}