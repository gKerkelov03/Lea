using Lea.Services.Interfaces.Data.Examination;
using Lea.Web.Commands.Examination.ExamQuestionAnswerOptions;
using Lea.Web.Responses.Examination.ExamQuestionAnswerOptions;
using MediatR;

namespace Lea.Web.Handlers.Examination.ExamQuestionAnswerOptions;

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