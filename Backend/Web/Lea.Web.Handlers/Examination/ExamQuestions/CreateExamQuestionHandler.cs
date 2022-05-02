using Lea.Services.Data.Interfaces.Examination;
using Lea.Web.Commands.Examination.ExamQuestions;
using Lea.Web.Responses.Examination.ExamQuestions;
using MediatR;

namespace Lea.Web.Handlers.Examination.ExamQuestions;

public class CreateExamQuestionHandler : IRequestHandler<CreateExamQuestionCommand, CreateExamQuestionResponse>
{
    private readonly IExamQuestionsService examQuestionsService;

    public CreateExamQuestionHandler(IExamQuestionsService examQuestionsService) 
        => this.examQuestionsService = examQuestionsService;

    public Task<CreateExamQuestionResponse> Handle(CreateExamQuestionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}