namespace Lea.Services;

public interface IRandomElementsSelector
{
    public IEnumerable<T> SelectFromCollection<T>(IEnumerable<T> collection, int targetCount);    
}