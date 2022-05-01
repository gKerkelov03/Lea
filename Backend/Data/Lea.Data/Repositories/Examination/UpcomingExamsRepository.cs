using Lea.Data.Entities.Examination;
using Lea.Data.Repositories.Interfaces.Examination;

namespace Lea.Data.Repositories.Examination;

public class UpcomingExamsRepository : BaseRepository<UpcomingExam>, IUpcomingTestsRepository
{
    public UpcomingExamsRepository(LeaDbContext context) : base(context)
    {
    }
}
