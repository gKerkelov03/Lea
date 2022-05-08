using MediatR;

namespace CQRS.Messaging.ChannelMessages.SetEmoji;

public class SetEmojiToChannelMessageCommand : IRequest<SetEmojiToChannelMessageResponse>
{
}