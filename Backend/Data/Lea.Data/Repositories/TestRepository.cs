using Lea.Data.Entities;
using Lea.Data.Repositories.Contracts;

namespace Lea.Data.Repositories;

public class TestRepository : BaseRepository<UpcomingTest>, ITestRepository
{
    public TestRepository(LeaDbContext context) : base(context)
    {
    }
}
