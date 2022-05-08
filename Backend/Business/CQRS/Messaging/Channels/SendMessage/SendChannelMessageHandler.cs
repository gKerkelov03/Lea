using Business.Interfaces.Data.Messaging;
using MediatR;

namespace CQRS.Messaging.Channels.SendMessage;

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