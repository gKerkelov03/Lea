using Lea.Data.Entities.Core;
using Lea.Data.Repositories.Interfaces.Core;

namespace Lea.Data.Repositories.Core;

public class CoursesRepository : BaseRepository<Course>, ICoursesRepository
{
    public CoursesRepository(LeaDbContext context) : base(context)
    {
    }
}
