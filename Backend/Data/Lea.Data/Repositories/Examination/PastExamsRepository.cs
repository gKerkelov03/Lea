using Lea.Data.Entities.Examination;
using Lea.Data.Interfaces.Examination;

namespace Lea.Data.Repositories.Examination;

public class PastTestsRepository : BaseRepository<PastExam>, IPastTestsRepository
{
    public PastTestsRepository(LeaDbContext context) : base(context)
    {
    }
}
