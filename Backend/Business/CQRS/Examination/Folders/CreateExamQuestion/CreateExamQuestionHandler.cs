using Business.Interfaces.Data.Examination;
using MediatR;

namespace CQRS.Examination.Folders.CreateExamQuestion;

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