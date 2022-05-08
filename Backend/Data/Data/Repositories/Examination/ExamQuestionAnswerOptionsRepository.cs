using Data.Entities.Examination;
using Data.Interfaces.Examination;

namespace Data.Repositories.Examination;

public class ExamQuestionAnswerOptionsRepository : BaseRepository<ExamQuestionAnswerOption>, IExamAnswerOptionsRepository
{
    public ExamQuestionAnswerOptionsRepository(LeaDbContext context) : base(context)
    {
    }
}
