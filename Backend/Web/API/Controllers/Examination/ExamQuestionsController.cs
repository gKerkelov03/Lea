using CQRS.Examination.ExamQuestions.Create;
using CQRS.Examination.ExamQuestions.Delete;
using CQRS.Examination.ExamQuestions.Get;
using CQRS.Examination.ExamQuestions.Update;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Examination;

public class ExamQuestionsController : ApiController
{
    public async Task<ActionResult<GetExamQuestionResponse>> GetExamQuestion(GetExamQuestionCommand getExamQuestionCommand)
        => await Mediator.Send(getExamQuestionCommand);

    public async Task<ActionResult<UpdateExamQuestionResponse>> UpdateExamQuestion(UpdateExamQuestionCommand updateExamQuestionCommand)
        => await Mediator.Send(updateExamQuestionCommand);

    public async Task<ActionResult<DeleteExamQuestionResponse>> DeleteExamQuestion(DeleteExamQuestionCommand deleteExamQuestionCommand)
        => await Mediator.Send(deleteExamQuestionCommand);

    public async Task<ActionResult<CreateExamQuestionAnswerOptionResponse>> CreateExamQuestionAnswerOption(CreateExamQuestionAnswerOptionCommand createExamAnswerOptionCommand)
       => await Mediator.Send(createExamAnswerOptionCommand);
}
