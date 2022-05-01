using Lea.Services.Interfaces;

namespace Lea.Services;

public class RandomNumbersGenerator : IRandomNumbersGenerator
{
    private Random randomGenerator;

    public RandomNumbersGenerator() 
        => randomGenerator = new Random();

    public int Next(int min, int max) 
        => randomGenerator.Next(min, max);

    public double NextDouble(int min, int max)
        => min + randomGenerator.NextDouble() * (max - min);
}
