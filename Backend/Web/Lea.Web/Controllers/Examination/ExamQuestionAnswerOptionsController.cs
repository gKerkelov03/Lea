using Lea.Web.Commands.Examination.ExamQuestionAnswerOptions;
using Lea.Web.Responses.Examination.ExamQuestionAnswerOptions;

namespace Lea.Web.Controllers.Examination;

public class ExamQuestionAnswerOptionsController : ApiController
{
    public async Task<CreateExamQuestionAnswerOptionResponse> CreateExamAnswerOption(CreateExamQuestionAnswerOptionCommand createExamAnswerOptionCommand)
        => await this.Mediator.Send(createExamAnswerOptionCommand);

    public async Task<GetExamQuestionAnswerOptionResponse> GetExamAnswerOption(GetExamQuestionAnswerOptionCommand getExamAnswerOptionCommand)
        => await this.Mediator.Send(getExamAnswerOptionCommand);

    public async Task<GetAllExamQuestionAnswerOptionsResponse> GetAllExamAnswerOptions(GetAllExamQuestionAnswerOptionsCommand getAllExamAnswerOptionsCommand)
        => await this.Mediator.Send(getAllExamAnswerOptionsCommand);

    public async Task<UpdateExamQuestionAnswerOptionResponse> UpdateExamAnswerOption(UpdateExamQuestionAnswerOptionCommand updateExamAnswerOptionCommand)
        => await this.Mediator.Send(updateExamAnswerOptionCommand);

    public async Task<DeleteExamQuestionAnswerOptionResponse> DeleteExamAnswerOption(DeleteExamQuestionAnswerOptionCommand deleteExamAnswerOptionCommand)
        => await this.Mediator.Send(deleteExamAnswerOptionCommand);
}
