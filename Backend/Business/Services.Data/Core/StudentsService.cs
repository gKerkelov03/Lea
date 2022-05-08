using AutoMapper;

namespace Services.Data.Core;

public class StudentsService : BaseDataService<Student, StudentServiceModel, StudentsRepository>, IStudentsService
{
    public StudentsService(StudentsRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
