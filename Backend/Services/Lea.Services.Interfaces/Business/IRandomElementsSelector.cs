namespace Lea.Services.Interfaces.Business;

public interface IRandomElementsSelector
{
    public IEnumerable<T> SelectFromCollection<T>(IEnumerable<T> collection, int targetCount);
}