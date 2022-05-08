using CQRS.Messaging.DirectMessages.Delete;
using CQRS.Messaging.DirectMessages.GetAllEmojis;
using CQRS.Messaging.DirectMessages.RemoveEmoji;
using CQRS.Messaging.DirectMessages.SendMessage;
using CQRS.Messaging.DirectMessages.SetEmoji;

namespace API.Controllers.Messaging;

public class DirectMessagesController : ApiController
{
    public async Task<SendDirectMessageResponse> SendDirectMessage(SendDirectMessageCommand sendDirectMessageCommand)
    => await Mediator.Send(sendDirectMessageCommand);

    public async Task<DeleteDirectMessageResponse> DeleteDirectMessage(DeleteDirectMessageCommand deleteDirectMessageCommand)
    => await Mediator.Send(deleteDirectMessageCommand);

    public async Task<SetEmojiToDirectMessageResponse> SetEmojiToMessage(SetEmojiToDirectMessageCommand setEmojiToMessageCommand)
    => await Mediator.Send(setEmojiToMessageCommand);

    public async Task<RemoveEmojiFromDirectMessageResponse> RemoveEmojiFromMessage(RemoveEmojiFromDirectMessageCommand removeEmojiFromMessageCommand)
    => await Mediator.Send(removeEmojiFromMessageCommand);

    public async Task<GetAllEmojisForADirectMessageResponse> GetAllEmojis(GetAllEmojisForADirectMessageCommand removeEmojiFromMessageCommand)
    => await Mediator.Send(removeEmojiFromMessageCommand);
}
