using Business.Interfaces.Data.Messaging;
using MediatR;

namespace CQRS.Messaging.ChannelMessages.RemoveEmoji;

public class RemoveEmojiFromChannelMessageHandler : IRequestHandler<RemoveEmojiFromChannelMessageCommand, RemoveEmojiFromChannelMessageResponse>
{
    private readonly IChannelsService channelsService;

    public RemoveEmojiFromChannelMessageHandler(IChannelsService channelsService)
        => this.channelsService = channelsService;

    public Task<RemoveEmojiFromChannelMessageResponse> Handle(RemoveEmojiFromChannelMessageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}