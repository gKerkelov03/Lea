using MediatR;

namespace CQRS.Messaging.ChannelMessages.RemoveEmoji;

public class RemoveEmojiFromChannelMessageCommand : IRequest<RemoveEmojiFromChannelMessageResponse>
{
}