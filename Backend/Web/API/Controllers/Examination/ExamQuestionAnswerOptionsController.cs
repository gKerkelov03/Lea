using CQRS.Examination.ExamQuestionAnswerOptions.Delete;
using CQRS.Examination.ExamQuestionAnswerOptions.Update;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Examination;

public class ExamQuestionAnswerOptionsController : ApiController
{
    public async Task<ActionResult<UpdateExamQuestionAnswerOptionResponse>> UpdateExamAnswerOption(UpdateExamQuestionAnswerOptionCommand updateExamAnswerOptionCommand)
        => await Mediator.Send(updateExamAnswerOptionCommand);

    public async Task<ActionResult<DeleteExamQuestionAnswerOptionResponse>> DeleteExamAnswerOption(DeleteExamQuestionAnswerOptionCommand deleteExamAnswerOptionCommand)
        => await Mediator.Send(deleteExamAnswerOptionCommand);
}
