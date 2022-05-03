using Lea.Web.Commands.Messaging.ChannelMessages;
using Lea.Web.Responses.Messaging.ChannelMessages;
using Microsoft.AspNetCore.Mvc;

namespace Lea.Web.Controllers.Messaging;

public class ChannelMessagesController : ApiController
{

    public async Task<ActionResult<GetChannelMessageResponse>> GetChannelMessage(GetChannelMessageCommand getChannelMessageCommand)
        => await this.Mediator.Send(getChannelMessageCommand);

    public async Task<ActionResult<GetAllChannelMessagesResponse>> GetAllChannelMessages(GetAllChannelMessagesCommand getAllChannelMessagesCommand)
        => await this.Mediator.Send(getAllChannelMessagesCommand);

    public async Task<SetEmojiToChannelMessageResponse> SetEmojiToMessage(SetEmojiToChannelMessageCommand setEmojiToMessageCommand)
    => await this.Mediator.Send(setEmojiToMessageCommand);

    public async Task<RemoveEmojiFromChannelMessageResponse> RemoveEmojiFromMessage(RemoveEmojiFromChannelMessageCommand removeEmojiFromMessageCommand)
    => await this.Mediator.Send(removeEmojiFromMessageCommand);

    public async Task<GetAllEmojisForAChannelMessageResponse> GetAllEmojis(GetAllEmojisForAChannelMessageCommand getAllEmojisForAChannelMessageCommand)
    => await this.Mediator.Send(getAllEmojisForAChannelMessageCommand);
}
