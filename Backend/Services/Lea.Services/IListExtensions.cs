using Lea.Services.Contracts;

namespace Lea.Services;

public class RandomElementsSelector : IRandomElementsSelector
{
    private readonly IRandomNumbersGenerator randomNumbersGenerator;

    public RandomElementsSelector(IRandomNumbersGenerator randomNumbersGenerator)
    {
        this.randomNumbersGenerator = randomNumbersGenerator;
    }

    public IEnumerable<T> SelectFromCollection<T>(IEnumerable<T> collection, int targetCount)
    {           
        var list = new List<T>(collection);

        if(targetCount < 0)
        {
            throw new ArgumentException($"The argument {nameof(targetCount)} should be greater than zero!");
        }

        if(list.Count < targetCount)
        {
            //TODO: ask tanya if is better to throw an exception here
            targetCount = list.Count;
        }

        T[] result = new T[targetCount];

        for (int i = 0; i < result.Length; i++)
        {
            var randomIndex = this.randomNumbersGenerator.Next(0, list.Count);
            result[i] = list[randomIndex];
            list.RemoveAt(randomIndex);
        }
        
        return result; 
    }   
}
