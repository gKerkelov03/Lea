using Lea.Services.Data.Interfaces.Examination;
using Lea.Web.Commands.Examination.ExamQuestionAnswerOptions;
using Lea.Web.Responses.Examination.ExamQuestionAnswerOptions;
using MediatR;

namespace Lea.Web.Handlers.Examination.ExamQuestionAnswerOptions;

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