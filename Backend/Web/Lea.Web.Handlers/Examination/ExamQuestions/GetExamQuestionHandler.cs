using Lea.Services.Data.Interfaces.Examination;
using Lea.Web.Commands.Examination.ExamQuestions;
using Lea.Web.Responses.Examination.ExamQuestions;
using MediatR;

namespace Lea.Web.Handlers.Examination.ExamQuestions;

public class GetExamQuestionHandler : IRequestHandler<GetExamQuestionCommand, GetExamQuestionResponse>
{
    private readonly IExamQuestionsService examQuestionsService;

    public GetExamQuestionHandler(IExamQuestionsService examQuestionsService)
        => this.examQuestionsService = examQuestionsService;

    public Task<GetExamQuestionResponse> Handle(GetExamQuestionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}