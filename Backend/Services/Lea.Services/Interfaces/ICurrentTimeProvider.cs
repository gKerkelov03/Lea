namespace Lea.Services.Interfaces;

public interface ICurrentTimeProvider : ITransientService
{
    DateTime Now { get; }
}
