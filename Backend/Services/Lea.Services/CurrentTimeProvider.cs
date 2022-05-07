using Lea.Services.Interfaces.Business;

namespace Lea.Services;

public class CurrentTimeProvider : ICurrentTimeProvider
{
    public DateTime Now => DateTime.Now;
}
