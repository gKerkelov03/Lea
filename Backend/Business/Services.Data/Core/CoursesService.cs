using AutoMapper;

namespace Services.Data.Core;

public class CoursesService : BaseDataService<Course, CourseServiceModel, CoursesRepository>, ICoursesService
{
    public CoursesService(CoursesRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
