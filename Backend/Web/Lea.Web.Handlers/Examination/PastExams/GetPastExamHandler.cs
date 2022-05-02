using Lea.Services.Data.Interfaces.Examination;
using Lea.Web.Commands.Examination.PastExams;
using Lea.Web.Responses.Examination.PastExams;
using MediatR;

namespace Lea.Web.Handlers.Examination.PastExams;

public class GetPastExamHandler : IRequestHandler<GetPastExamCommand, GetPastExamResponse>
{
    private readonly IPastExamsService pastExamsService;

    public GetPastExamHandler(IPastExamsService pastExamsService)
        => this.pastExamsService = pastExamsService;

    public Task<GetPastExamResponse> Handle(GetPastExamCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}