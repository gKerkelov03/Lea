using AutoMapper;
using Lea.Data.Entities.Core;
using Lea.Data.Repositories.Core;
using Lea.Services.Data.Interfaces.Core;
using Lea.Services.Data.Models.Core;

namespace Lea.Services.Data.Core;

public class StudentsService : BaseDataService<Student, StudentServiceModel, StudentsRepository>, IStudentsService
{
    public StudentsService(StudentsRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
