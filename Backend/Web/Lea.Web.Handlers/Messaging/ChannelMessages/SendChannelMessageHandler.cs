using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Messaging.ChannelMessages;
using Lea.Web.Responses.Messaging.ChannelMessages;
using MediatR;

namespace Lea.Web.Handlers.Messaging.ChannelMessages;

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