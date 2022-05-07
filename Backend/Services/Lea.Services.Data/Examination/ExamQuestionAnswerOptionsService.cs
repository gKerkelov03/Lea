using AutoMapper;
using Lea.Data.Entities.Examination;
using Lea.Data.Repositories.Examination;
using Lea.Services.Data.Models.Examination;
using Lea.Services.Interfaces.Data.Examination;

namespace Lea.Services.Data.Examination;

public class ExamQuestionAnswerOptionsService : BaseDataService<ExamQuestionAnswerOption, ExamQuestionAnswerOptionServiceModel, ExamQuestionAnswerOptionsRepository>, IExamQuestionAnswerOptionsService
{
    public ExamQuestionAnswerOptionsService(ExamQuestionAnswerOptionsRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
