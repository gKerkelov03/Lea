using Lea.Common.Conventions;

namespace Lea.Services.Interfaces.Business;
public interface IRandomNumbersGenerator : ITransientService
{
    int Next(int min, int max);
    double NextDouble(int min, int max);
}
