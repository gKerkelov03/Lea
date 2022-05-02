using Lea.Web.Commands.Messaging.Emojis;
using Lea.Web.Responses.Messaging.Emojis;

namespace Lea.Web.Controllers.Messaging;

public class EmojisController : ApiController
{
    public async Task<SetEmojiToMessageResponse> SetEmojiToMessage(SetEmojiToMessageCommand setEmojiToMessageCommand)
    => await this.Mediator.Send(setEmojiToMessageCommand);

    public async Task<RemoveEmojiFromMessageResponse> RemoveEmojiFromMessage(RemoveEmojiFromMessageCommand removeEmojiFromMessageCommand)
    => await this.Mediator.Send(removeEmojiFromMessageCommand);

    public async Task<GetAllEmojisResponse> GetAllEmojis(GetAllEmojisCommand removeEmojiFromMessageCommand)
    => await this.Mediator.Send(removeEmojiFromMessageCommand);
}
