using Lea.Web.Commands.Examination.ExamQuestions;
using Lea.Web.Responses.Examination.ExamQuestions;
using Microsoft.AspNetCore.Mvc;

namespace Lea.Web.Controllers.Examination;

public class ExamQuestionsController : ApiController
{    
    public async Task<ActionResult<GetExamQuestionResponse>> GetExamQuestion(GetExamQuestionCommand getExamQuestionCommand)
        => await this.Mediator.Send(getExamQuestionCommand);
    
    public async Task<ActionResult<UpdateExamQuestionResponse>> UpdateExamQuestion(UpdateExamQuestionCommand updateExamQuestionCommand)
        => await this.Mediator.Send(updateExamQuestionCommand);

    public async Task<ActionResult<DeleteExamQuestionResponse>> DeleteExamQuestion(DeleteExamQuestionCommand deleteExamQuestionCommand)
        => await this.Mediator.Send(deleteExamQuestionCommand);

    public async Task<ActionResult<CreateExamQuestionAnswerOptionResponse>> CreateExamQuestionAnswerOption(CreateExamQuestionAnswerOptionCommand createExamAnswerOptionCommand)
       => await this.Mediator.Send(createExamAnswerOptionCommand);
}
