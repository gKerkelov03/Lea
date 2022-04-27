using Lea.Services.Contracts;

namespace Lea.Services;

public class CurrentTimeProvider : ICurrentTimeProvider
{
    public DateTime Now => DateTime.Now;
}
