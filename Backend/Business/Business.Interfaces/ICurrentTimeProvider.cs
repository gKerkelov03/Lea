using Common.Conventions;

namespace Business.Interfaces;

public interface ICurrentTimeProvider : ITransientService
{
    DateTime Now { get; }
}
