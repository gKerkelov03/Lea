using Lea.Services.Data.Interfaces.Examination;
using Lea.Web.Commands.Examination.ExamQuestions;
using Lea.Web.Responses.Examination.ExamQuestions;
using MediatR;

namespace Lea.Web.Handlers.Examination.ExamQuestions;

public class DeleteExamQuestionHandler : IRequestHandler<DeleteExamQuestionCommand, DeleteExamQuestionResponse>
{
    private readonly IExamQuestionsService examQuestionsService;

    public DeleteExamQuestionHandler(IExamQuestionsService examQuestionsService)
        => this.examQuestionsService = examQuestionsService;

    public Task<DeleteExamQuestionResponse> Handle(DeleteExamQuestionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}