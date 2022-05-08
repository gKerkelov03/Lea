using MediatR;

namespace CQRS.Messaging.DirectMessages.RemoveEmoji;

public class RemoveEmojiFromDirectMessageCommand : IRequest<RemoveEmojiFromDirectMessageResponse>
{
}