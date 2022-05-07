using Lea.Web.Commands.Messaging.DirectMessages;
using Lea.Web.Responses.Messaging.DirectMessages;

namespace Lea.Web.Controllers.Messaging;

public class DirectMessagesController : ApiController
{
    public async Task<SendDirectMessageResponse> SendDirectMessage(SendDirectMessageCommand sendDirectMessageCommand)
    => await this.Mediator.Send(sendDirectMessageCommand);

    public async Task<DeleteDirectMessageResponse> DeleteDirectMessage(DeleteDirectMessageCommand deleteDirectMessageCommand)
    => await this.Mediator.Send(deleteDirectMessageCommand);

    public async Task<SetEmojiToDirectMessageResponse> SetEmojiToMessage(SetEmojiToDirectMessageCommand setEmojiToMessageCommand)
    => await this.Mediator.Send(setEmojiToMessageCommand);

    public async Task<RemoveEmojiFromDirectMessageResponse> RemoveEmojiFromMessage(RemoveEmojiFromDirectMessageCommand removeEmojiFromMessageCommand)
    => await this.Mediator.Send(removeEmojiFromMessageCommand);

    public async Task<GetAllEmojisForADirectMessageResponse> GetAllEmojis(GetAllEmojisForADirectMessageCommand removeEmojiFromMessageCommand)
    => await this.Mediator.Send(removeEmojiFromMessageCommand);
}
