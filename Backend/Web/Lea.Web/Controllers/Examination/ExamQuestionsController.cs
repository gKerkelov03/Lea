using Lea.Web.Commands.Examination.ExamQuestions;
using Lea.Web.Responses.Examination.ExamQuestions;

namespace Lea.Web.Controllers.Examination;

public class ExamQuestionsController : ApiController
{
    public async Task<CreateExamQuestionResponse> CreateExamQuestion(CreateExamQuestionCommand createExamQuestionCommand)
        => await this.Mediator.Send(createExamQuestionCommand);

    public async Task<GetExamQuestionResponse> GetExamQuestion(GetExamQuestionCommand getExamQuestionCommand)
        => await this.Mediator.Send(getExamQuestionCommand);

    public async Task<GetAllExamQuestionsResponse> GetAllExamQuestions(GetAllExamQuestionsCommand getAllExamQuestionsCommand)
        => await this.Mediator.Send(getAllExamQuestionsCommand);

    public async Task<UpdateExamQuestionResponse> UpdateExamQuestion(UpdateExamQuestionCommand updateExamQuestionCommand)
        => await this.Mediator.Send(updateExamQuestionCommand);

    public async Task<DeleteExamQuestionResponse> DeleteExamQuestion(DeleteExamQuestionCommand deleteExamQuestionCommand)
        => await this.Mediator.Send(deleteExamQuestionCommand);
}
