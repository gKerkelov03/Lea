using Business.Interfaces.Data.Examination;
using MediatR;

namespace CQRS.Examination.ExamQuestionAnswerOptions.Delete;

public class DeleteExamQuestionAnswerOptionHandler : IRequestHandler<DeleteExamQuestionAnswerOptionCommand, DeleteExamQuestionAnswerOptionResponse>
{
    private readonly IExamQuestionAnswerOptionsService examQuestionAnswerOptionsService;

    public DeleteExamQuestionAnswerOptionHandler(IExamQuestionAnswerOptionsService examQuestionAnswerOptionsService)
        => this.examQuestionAnswerOptionsService = examQuestionAnswerOptionsService;

    public Task<DeleteExamQuestionAnswerOptionResponse> Handle(DeleteExamQuestionAnswerOptionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}