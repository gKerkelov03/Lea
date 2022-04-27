using Lea.Services.Contracts;

namespace Lea.Services;

public class RandomService : IRandomService
{
    private Random randomGenerator;

    public RandomService() => randomGenerator = new Random();

    public int Next(int min, int max) => randomGenerator.Next(min, max);

    public double NextDouble(int min, int max)
        => min + randomGenerator.NextDouble() * (max - min);
}
