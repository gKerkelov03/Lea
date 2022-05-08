using Business.Interfaces.Data.Examination;
using MediatR;

namespace CQRS.Examination.ExamQuestions.Update;

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