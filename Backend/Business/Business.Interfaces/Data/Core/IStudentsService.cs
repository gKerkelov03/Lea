using Data.Entities.Core;
using Services.Data.Models.Core;

namespace Business.Interfaces.Data.Core;

public interface IStudentsService : IBaseDataService<Student, StudentServiceModel>
{
}
