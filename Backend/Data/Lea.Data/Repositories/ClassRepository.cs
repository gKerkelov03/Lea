using Lea.Data.Entities;
using Lea.Data.Repositories.Contracts;

namespace Lea.Data.Repositories;

public class ClassRepository : BaseRepository<Group>, IClassRepository
{
    public ClassRepository(LeaDbContext context) : base(context)
    {
    }
}
