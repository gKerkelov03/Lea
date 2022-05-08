using Common.Conventions;

namespace Business.Interfaces;
public interface IRandomNumbersGenerator : ITransientService
{
    int Next(int min, int max);
    double NextDouble(int min, int max);
}
