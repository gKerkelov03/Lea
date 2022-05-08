using AutoMapper;

namespace Mappings.Conventions;

public interface IHaveCustomMappings
{
    void CreateMappings(IProfileExpression configuration);
}
