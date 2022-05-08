using Business.Interfaces.Data.Examination;
using MediatR;

namespace CQRS.Examination.ExamQuestions.Create;

public class CreateExamQuestionAnswerOptionHandler : IRequestHandler<CreateExamQuestionAnswerOptionCommand, CreateExamQuestionAnswerOptionResponse>
{
    private readonly IExamQuestionAnswerOptionsService examQuestionAnswerOptionsService;

    public CreateExamQuestionAnswerOptionHandler(IExamQuestionAnswerOptionsService examQuestionAnswerOptionsService)
        => this.examQuestionAnswerOptionsService = examQuestionAnswerOptionsService;

    public Task<CreateExamQuestionAnswerOptionResponse> Handle(CreateExamQuestionAnswerOptionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}