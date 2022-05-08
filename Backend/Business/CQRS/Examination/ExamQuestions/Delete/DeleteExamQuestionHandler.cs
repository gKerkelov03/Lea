using Business.Interfaces.Data.Examination;
using MediatR;

namespace CQRS.Examination.ExamQuestions.Delete;

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