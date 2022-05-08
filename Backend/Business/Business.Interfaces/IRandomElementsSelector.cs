using Common.Conventions;

namespace Business.Interfaces;

public interface IRandomElementsSelector : ITransientService
{
    public IEnumerable<T> SelectFromCollection<T>(IEnumerable<T> collection, int targetCount);
}