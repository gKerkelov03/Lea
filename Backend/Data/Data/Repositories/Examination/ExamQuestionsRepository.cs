using Data.Entities.Examination;
using Data.Interfaces.Examination;

namespace Data.Repositories.Examination;

public class ExamQuestionsRepository : BaseRepository<ExamQuestion>, IExamQuestionsRepository
{
    public ExamQuestionsRepository(LeaDbContext context) : base(context)
    {
    }
}
