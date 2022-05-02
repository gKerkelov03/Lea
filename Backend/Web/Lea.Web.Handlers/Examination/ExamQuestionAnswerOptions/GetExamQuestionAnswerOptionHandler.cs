using Lea.Services.Data.Interfaces.Examination;
using Lea.Web.Commands.Examination.ExamQuestionAnswerOptions;
using Lea.Web.Responses.Examination.ExamQuestionAnswerOptions;
using MediatR;

namespace Lea.Web.Handlers.Examination.ExamQuestionAnswerOptions;

public class GetExamQuestionAnswerOptionHandler : IRequestHandler<GetExamQuestionAnswerOptionCommand, GetExamQuestionAnswerOptionResponse>
{
    private readonly IExamQuestionAnswerOptionsService examQuestionAnswerOptionsService;

    public GetExamQuestionAnswerOptionHandler(IExamQuestionAnswerOptionsService examQuestionAnswerOptionsService)
        => this.examQuestionAnswerOptionsService = examQuestionAnswerOptionsService;

    public Task<GetExamQuestionAnswerOptionResponse> Handle(GetExamQuestionAnswerOptionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}