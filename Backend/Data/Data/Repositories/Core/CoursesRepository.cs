using Data.Entities.Core;
using Data.Interfaces.Core;

namespace Data.Repositories.Core;

public class CoursesRepository : BaseRepository<Course>, ICoursesRepository
{
    public CoursesRepository(LeaDbContext context) : base(context)
    {
    }
}
