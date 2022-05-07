using Lea.Services.Interfaces.Data.Examination;
using Lea.Web.Commands.Examination.ExamQuestions;
using Lea.Web.Responses.Examination.ExamQuestions;
using MediatR;

namespace Lea.Web.Handlers.Examination.ExamQuestions;

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