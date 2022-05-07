using Lea.Services.Interfaces.Data.Messaging;
using Lea.Web.Commands.Core.Groups;
using Lea.Web.Responses.Core.Groups;
using MediatR;

namespace Lea.Web.Handlers.Core.Groups;

public class GetAllChannelsForAGroupHandler : IRequestHandler<GetAllChannelsForAGroupCommand, GetAllChannelsForAGroupResponse>
{
    private readonly IChannelsService channelsService;

    public GetAllChannelsForAGroupHandler(IChannelsService channelsService)
        => this.channelsService = channelsService;

    public Task<GetAllChannelsForAGroupResponse> Handle(GetAllChannelsForAGroupCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}