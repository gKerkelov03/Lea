using Lea.Common.Conventions;

namespace Lea.Services.Interfaces.Business;

public interface ICurrentTimeProvider : ITransientService
{
    DateTime Now { get; }
}
