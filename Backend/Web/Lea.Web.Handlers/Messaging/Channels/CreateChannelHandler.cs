using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Messaging.Channels;
using Lea.Web.Responses.Messaging.Channels;
using MediatR;

namespace Lea.Web.Handlers.Messaging.Channels;

public class CreateChannelHandler : IRequestHandler<CreateChannelCommand, CreateChannelResponse>
{
    private readonly IChannelsService channelsService;

    public CreateChannelHandler(IChannelsService channelsService)
        => this.channelsService = channelsService;

    public Task<CreateChannelResponse> Handle(CreateChannelCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}