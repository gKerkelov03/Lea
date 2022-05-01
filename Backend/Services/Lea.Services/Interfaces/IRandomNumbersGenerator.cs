using Lea.Common.Conventions;

namespace Lea.Services.Interfaces;
public interface IRandomNumbersGenerator : ITransientService
{
    int Next(int min, int max);
    double NextDouble(int min, int max);
}
