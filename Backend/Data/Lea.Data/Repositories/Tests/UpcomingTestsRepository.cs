using Lea.Data.Entities.Tests;
using Lea.Data.Repositories.Interfaces.Tests;

namespace Lea.Data.Repositories.Tests;

public class UpcomingTestsRepository : BaseRepository<UpcomingTest>, IUpcomingTestsRepository
{
    public UpcomingTestsRepository(LeaDbContext context) : base(context)
    {
    }
}
