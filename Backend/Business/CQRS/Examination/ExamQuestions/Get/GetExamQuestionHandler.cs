using Business.Interfaces.Data.Examination;
using MediatR;

namespace CQRS.Examination.ExamQuestions.Get;

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