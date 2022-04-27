using Lea.Data.Entities;
using Lea.Data.Repositories.Contracts;

namespace Lea.Data.Repositories;

public class SchoolRepository : BaseRepository<Course>, ISchoolRepository
{
    public SchoolRepository(LeaDbContext context) : base(context)
    {
    }
}
