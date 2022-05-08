using CQRS.Messaging.ChannelMessages.GetAllEmojis;
using CQRS.Messaging.ChannelMessages.RemoveEmoji;
using CQRS.Messaging.ChannelMessages.SetEmoji;

namespace API.Controllers.Messaging;

public class ChannelMessagesController : ApiController
{
    public async Task<SetEmojiToChannelMessageResponse> SetEmojiToMessage(SetEmojiToChannelMessageCommand setEmojiToMessageCommand)
    => await Mediator.Send(setEmojiToMessageCommand);

    public async Task<RemoveEmojiFromChannelMessageResponse> RemoveEmojiFromMessage(RemoveEmojiFromChannelMessageCommand removeEmojiFromMessageCommand)
    => await Mediator.Send(removeEmojiFromMessageCommand);

    public async Task<GetAllEmojisForAChannelMessageResponse> GetAllEmojis(GetAllEmojisForAChannelMessageCommand getAllEmojisForAChannelMessageCommand)
    => await Mediator.Send(getAllEmojisForAChannelMessageCommand);
}
