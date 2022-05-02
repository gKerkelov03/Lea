using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Messaging.Channels;
using Lea.Web.Responses.Messaging.Channels;
using MediatR;

namespace Lea.Web.Handlers.Messaging.Channels;

public class GetChannelHandler : IRequestHandler<GetChannelCommand, GetChannelResponse>
{
    private readonly IChannelsService channelsService;

    public GetChannelHandler(IChannelsService channelsService)
        => this.channelsService = channelsService;

    public Task<GetChannelResponse> Handle(GetChannelCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}