using Lea.Data.Entities;
using Lea.Data.Repositories.Contracts;

namespace Lea.Data.Repositories;

public class ClassRepository : BaseRepository<Class>, IClassRepository
{
    public ClassRepository(LeaDbContext context) : base(context)
    {
    }
}
