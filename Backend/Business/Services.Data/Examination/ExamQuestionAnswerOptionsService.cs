using AutoMapper;

namespace Services.Data.Examination;

public class ExamQuestionAnswerOptionsService : BaseDataService<ExamQuestionAnswerOption, ExamQuestionAnswerOptionServiceModel, ExamQuestionAnswerOptionsRepository>, IExamQuestionAnswerOptionsService
{
    public ExamQuestionAnswerOptionsService(ExamQuestionAnswerOptionsRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
