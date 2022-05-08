using Business.Interfaces.Data.Messaging;
using MediatR;

namespace CQRS.Messaging.ChannelMessages.SetEmoji;

public class SetEmojiToChannelMessageHandler : IRequestHandler<SetEmojiToChannelMessageCommand, SetEmojiToChannelMessageResponse>
{
    private readonly IChannelsService channelsService;

    public SetEmojiToChannelMessageHandler(IChannelsService channelsService)
        => this.channelsService = channelsService;

    public Task<SetEmojiToChannelMessageResponse> Handle(SetEmojiToChannelMessageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}