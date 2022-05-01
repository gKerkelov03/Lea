using Lea.Services.Interfaces;

namespace Lea.Services;

public class CurrentTimeProvider : ICurrentTimeProvider
{
    public DateTime Now => DateTime.Now;
}
