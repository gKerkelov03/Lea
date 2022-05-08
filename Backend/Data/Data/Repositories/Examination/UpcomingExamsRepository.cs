using Data.Entities.Examination;
using Data.Interfaces.Examination;

namespace Data.Repositories.Examination;

public class UpcomingExamsRepository : BaseRepository<UpcomingExam>, IUpcomingTestsRepository
{
    public UpcomingExamsRepository(LeaDbContext context) : base(context)
    {
    }
}
