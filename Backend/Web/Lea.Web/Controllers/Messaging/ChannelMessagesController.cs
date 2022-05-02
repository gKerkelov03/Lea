using Lea.Web.Commands.Messaging.ChannelMessages;
using Lea.Web.Responses.Messaging.ChannelMessages;

namespace Lea.Web.Controllers.Messaging;

public class ChannelMessagesController : ApiController
{
    public async Task<SendChannelMessageResponse> SendChannelMessage(SendChannelMessageCommand sendChannelMessageCommand)
        => await this.Mediator.Send(sendChannelMessageCommand);

    public async Task<GetChannelMessageResponse> GetChannelMessage(GetChannelMessageCommand getChannelMessageCommand)
        => await this.Mediator.Send(getChannelMessageCommand);

    public async Task<GetAllChannelMessagesResponse> GetAllChannelMessages(GetAllChannelMessagesCommand getAllChannelMessagesCommand)
        => await this.Mediator.Send(getAllChannelMessagesCommand);
}
