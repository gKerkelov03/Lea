using Lea.Data.Entities.Secondary;
using Lea.Data.Repositories.Interfaces.Secondary;

namespace Lea.Data.Repositories.Secondary;

public class TestQuestionsRepository : BaseRepository<TestQuestion>, ITestQuestionsRepository
{
    public TestQuestionsRepository(LeaDbContext context) : base(context)
    {
    }
}
