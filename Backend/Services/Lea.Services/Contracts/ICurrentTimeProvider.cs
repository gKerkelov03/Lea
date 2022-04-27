namespace Lea.Services.Contracts;

public interface ICurrentTimeProvider : ITransientService
{
    DateTime Now { get; }
}
