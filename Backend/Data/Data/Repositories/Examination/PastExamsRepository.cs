using Data.Entities.Examination;
using Data.Interfaces.Examination;

namespace Data.Repositories.Examination;

public class PastTestsRepository : BaseRepository<PastExam>, IPastTestsRepository
{
    public PastTestsRepository(LeaDbContext context) : base(context)
    {
    }
}
