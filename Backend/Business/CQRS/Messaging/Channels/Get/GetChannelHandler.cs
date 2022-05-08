using Business.Interfaces.Data.Messaging;
using MediatR;

namespace CQRS.Messaging.Channels.Get;

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