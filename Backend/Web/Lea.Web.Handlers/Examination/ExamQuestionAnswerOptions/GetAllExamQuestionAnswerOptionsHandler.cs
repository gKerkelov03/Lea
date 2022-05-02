using Lea.Services.Data.Interfaces.Examination;
using Lea.Web.Commands.Examination.ExamQuestionAnswerOptions;
using Lea.Web.Responses.Examination.ExamQuestionAnswerOptions;
using MediatR;

namespace Lea.Web.Handlers.Examination.ExamQuestionAnswerOptions;

public class GetAllExamQuestionAnswerOptionsHandler : IRequestHandler<GetAllExamQuestionAnswerOptionsCommand, GetAllExamQuestionAnswerOptionsResponse>
{
    private readonly IExamQuestionAnswerOptionsService examQuestionAnswerOptionsService;

    public GetAllExamQuestionAnswerOptionsHandler(IExamQuestionAnswerOptionsService examQuestionAnswerOptionsService)
        => this.examQuestionAnswerOptionsService = examQuestionAnswerOptionsService;

    public Task<GetAllExamQuestionAnswerOptionsResponse> Handle(GetAllExamQuestionAnswerOptionsCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}