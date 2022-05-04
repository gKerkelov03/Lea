using Lea.Services.Data.Interfaces.Examination;
using Lea.Web.Commands.Examination.PastExams;
using Lea.Web.Responses.Examination.PastExams;
using MediatR;

namespace Lea.Web.Handlers.Examination.PastExams;

public class GetAllPastExamsForAGroupHandler : IRequestHandler<GetAllPastExamsForAGroupCommand, GetAllPastExamsForAGroupResponse>
{
    private readonly IPastExamsService pastExamsService;

    public GetAllPastExamsForAGroupHandler(IPastExamsService pastExamsService)
        => this.pastExamsService = pastExamsService;

    public Task<GetAllPastExamsForAGroupResponse> Handle(GetAllPastExamsForAGroupCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}