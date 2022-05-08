using CQRS.Messaging.Emojis;

namespace API.Controllers.Messaging;

public class EmojisController : ApiController
{
    public async Task<GetAllEmojisResponse> GetAllEmojis(GetAllEmojisCommand removeEmojiFromMessageCommand)
        => await Mediator.Send(removeEmojiFromMessageCommand);
}
