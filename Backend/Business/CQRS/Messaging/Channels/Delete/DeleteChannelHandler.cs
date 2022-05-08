using Business.Interfaces.Data.Messaging;
using MediatR;

namespace CQRS.Messaging.Channels.Delete;

public class DeleteChannelHandler : IRequestHandler<DeleteChannelCommand, DeleteChannelResponse>
{
    private readonly IChannelsService channelsService;

    public DeleteChannelHandler(IChannelsService channelsService)
        => this.channelsService = channelsService;

    public Task<DeleteChannelResponse> Handle(DeleteChannelCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}