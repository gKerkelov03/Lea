using Lea.Services.Interfaces.Data.Examination;
using Lea.Web.Commands.Core.Groups;
using Lea.Web.Responses.Core.Groups;
using MediatR;

namespace Lea.Web.Handlers.Core.Groups;

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