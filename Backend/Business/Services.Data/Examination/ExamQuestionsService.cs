using AutoMapper;

namespace Services.Data.Examination;

public class ExamQuestionsService : BaseDataService<ExamQuestion, ExamQuestionServiceModel, ExamQuestionsRepository>, IExamQuestionsService
{
    public ExamQuestionsService(ExamQuestionsRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
