using Lea.Web.Commands.Examination.ExamQuestionAnswerOptions;
using Lea.Web.Responses.Examination.ExamQuestionAnswerOptions;
using Microsoft.AspNetCore.Mvc;

namespace Lea.Web.Controllers.Examination;

public class ExamQuestionAnswerOptionsController : ApiController
{         
    public async Task<ActionResult<UpdateExamQuestionAnswerOptionResponse>> UpdateExamAnswerOption(UpdateExamQuestionAnswerOptionCommand updateExamAnswerOptionCommand)
        => await this.Mediator.Send(updateExamAnswerOptionCommand);

    public async Task<ActionResult<DeleteExamQuestionAnswerOptionResponse>> DeleteExamAnswerOption(DeleteExamQuestionAnswerOptionCommand deleteExamAnswerOptionCommand)
        => await this.Mediator.Send(deleteExamAnswerOptionCommand);
}
