using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Messaging.Channels;
using Lea.Web.Responses.Messaging.Channels;
using MediatR;

namespace Lea.Web.Handlers.Messaging.Channels;

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