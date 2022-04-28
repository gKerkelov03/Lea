using Lea.Data.Entities.Secondary;
using Lea.Data.Repositories.Interfaces.Secondary;

namespace Lea.Data.Repositories.Secondary;

public class TestAnswerOptionsRepository : BaseRepository<TestAnswerOption>, ITestAnswerOptionsRepository
{
    public TestAnswerOptionsRepository(LeaDbContext context) : base(context)
    {
    }
}
