using Lea.Web.Responses.Core.Groups;
using Lea.Web.Responses.Messaging.Emojis;
using MediatR;

namespace Lea.Web.Commands.Messaging.Emojis;

public class SetEmojiToMessageCommand : IRequest<SetEmojiToMessageResponse>
{
}