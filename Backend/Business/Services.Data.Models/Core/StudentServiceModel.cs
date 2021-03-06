using Data.Entities.Core;
using Mappings.Conventions;

namespace Services.Data.Models.Core;

public class StudentServiceModel : BaseServiceModel, IMapToAndFrom<Student>
{
}