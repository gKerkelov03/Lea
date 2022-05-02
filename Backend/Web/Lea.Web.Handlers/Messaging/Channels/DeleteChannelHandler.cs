using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Messaging.Channels;
using Lea.Web.Responses.Messaging.Channels;
using MediatR;

namespace Lea.Web.Handlers.Messaging.Channels;

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