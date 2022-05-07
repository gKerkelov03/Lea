using Lea.Services.Interfaces.Data.Examination;
using Lea.Web.Commands.Examination.Folders;
using Lea.Web.Responses.Examination.Folders;
using MediatR;

namespace Lea.Web.Handlers.Examination.Folders;

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