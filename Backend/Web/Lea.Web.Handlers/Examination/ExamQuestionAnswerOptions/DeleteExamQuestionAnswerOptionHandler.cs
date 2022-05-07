using Lea.Services.Interfaces.Data.Examination;
using Lea.Web.Commands.Examination.ExamQuestionAnswerOptions;
using Lea.Web.Responses.Examination.ExamQuestionAnswerOptions;
using MediatR;

namespace Lea.Web.Handlers.Examination.ExamQuestionAnswerOptions;

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