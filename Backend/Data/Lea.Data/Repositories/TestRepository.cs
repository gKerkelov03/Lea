using Lea.Data.Entities;
using Lea.Data.Repositories.Contracts;

namespace Lea.Data.Repositories;

public class TestRepository : BaseRepository<Test>, ITestRepository
{
    public TestRepository(LeaDbContext context) : base(context)
    {
    }
}
