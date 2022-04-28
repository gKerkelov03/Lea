using Lea.Data.Entities.Tests;
using Lea.Data.Repositories.Interfaces.Tests;

namespace Lea.Data.Repositories.Tests;

public class PastTestsRepository : BaseRepository<PastTest>, IPastTestsRepository
{
    public PastTestsRepository(LeaDbContext context) : base(context)
    {
    }
}
