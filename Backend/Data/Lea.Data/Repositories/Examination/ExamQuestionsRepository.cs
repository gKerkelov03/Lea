using Lea.Data.Entities.Examination;
using Lea.Data.Interfaces.Examination;

namespace Lea.Data.Repositories.Examination;

public class ExamQuestionsRepository : BaseRepository<ExamQuestion>, IExamQuestionsRepository
{
    public ExamQuestionsRepository(LeaDbContext context) : base(context)
    {
    }
}
