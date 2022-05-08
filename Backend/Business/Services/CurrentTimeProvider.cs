namespace Services;

public class CurrentTimeProvider : ICurrentTimeProvider
{
    public DateTime Now => DateTime.Now;
}
