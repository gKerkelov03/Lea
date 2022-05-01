using Lea.Data.Entities.Examination;
using Lea.Data.Repositories.Interfaces.Examination;

namespace Lea.Data.Repositories.Examination;

public class ExamQuestionAnswerOptionsRepository : BaseRepository<ExamQuestionAnswerOption>, IExamAnswerOptionsRepository
{
    public ExamQuestionAnswerOptionsRepository(LeaDbContext context) : base(context)
    {
    }
}
