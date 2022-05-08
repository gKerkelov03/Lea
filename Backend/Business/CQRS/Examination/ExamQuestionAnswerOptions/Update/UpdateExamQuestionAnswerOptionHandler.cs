using Business.Interfaces.Data.Examination;
using MediatR;

namespace CQRS.Examination.ExamQuestionAnswerOptions.Update;

public class UpdateExamQuestionAnswerOptionHandler : IRequestHandler<UpdateExamQuestionAnswerOptionCommand, UpdateExamQuestionAnswerOptionResponse>
{
    private readonly IExamQuestionAnswerOptionsService examQuestionAnswerOptionsService;

    public UpdateExamQuestionAnswerOptionHandler(IExamQuestionAnswerOptionsService examQuestionAnswerOptionsService)
        => this.examQuestionAnswerOptionsService = examQuestionAnswerOptionsService;

    public Task<UpdateExamQuestionAnswerOptionResponse> Handle(UpdateExamQuestionAnswerOptionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}