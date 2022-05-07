using Lea.Services.Interfaces.Data.Examination;
using Lea.Web.Commands.Examination.ExamQuestions;
using Lea.Web.Responses.Examination.ExamQuestions;
using MediatR;

namespace Lea.Web.Handlers.Examination.ExamQuestions;

public class UpdateExamQuestionHandler : IRequestHandler<UpdateExamQuestionCommand, UpdateExamQuestionResponse>
{
    private readonly IExamQuestionsService examQuestionsService;

    public UpdateExamQuestionHandler(IExamQuestionsService examQuestionsService)
        => this.examQuestionsService = examQuestionsService;

    public Task<UpdateExamQuestionResponse> Handle(UpdateExamQuestionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}