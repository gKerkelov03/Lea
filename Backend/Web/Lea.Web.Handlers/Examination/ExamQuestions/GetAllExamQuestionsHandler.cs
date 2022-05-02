using Lea.Services.Data.Interfaces.Examination;
using Lea.Web.Commands.Examination.ExamQuestions;
using Lea.Web.Responses.Examination.ExamQuestions;
using MediatR;

namespace Lea.Web.Handlers.Examination.ExamQuestions;

public class GetAllExamQuestionsHandler : IRequestHandler<GetAllExamQuestionsCommand, GetAllExamQuestionsResponse>
{
    private readonly IExamQuestionsService examQuestionsService;

    public GetAllExamQuestionsHandler(IExamQuestionsService examQuestionsService)
        => this.examQuestionsService = examQuestionsService;

    public Task<GetAllExamQuestionsResponse> Handle(GetAllExamQuestionsCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}