using Lea.Services.Interfaces.Data.Messaging;
using Lea.Web.Commands.Messaging.Channels;
using Lea.Web.Responses.Messaging.Channels;
using MediatR;

namespace Lea.Web.Handlers.Messaging.Channels;

public class SendChannelMessageHandler : IRequestHandler<SendChannelMessageCommand, SendChannelMessageResponse>
{
    private readonly IChannelMessagesService channelMessagesService;

    public SendChannelMessageHandler(IChannelMessagesService channelMessagesService)
        => this.channelMessagesService = channelMessagesService;

    public Task<SendChannelMessageResponse> Handle(SendChannelMessageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}