using Lea.Services.Data.Interfaces.Examination;
using Lea.Web.Commands.Examination.PastExams;
using Lea.Web.Responses.Examination.PastExams;
using MediatR;

namespace Lea.Web.Handlers.Examination.PastExams;

public class GetAllPastExamsHandler : IRequestHandler<GetAllPastExamsCommand, GetAllPastExamsResponse>
{
    private readonly IPastExamsService pastExamsService;

    public GetAllPastExamsHandler(IPastExamsService pastExamsService)
        => this.pastExamsService = pastExamsService;

    public Task<GetAllPastExamsResponse> Handle(GetAllPastExamsCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}