using Lea.Web.Commands.Messaging.Channels;
using Lea.Web.Responses.Messaging.Channels;
using Microsoft.AspNetCore.Mvc;

namespace Lea.Web.Controllers.Messaging;

public class ChannelsController : ApiController
{    
    public async Task<DeleteChannelResponse> DeleteChannel(DeleteChannelCommand deleteChannelCommand)
    => await this.Mediator.Send(deleteChannelCommand);

    public async Task<EditChannelResponse> EditChannel(EditChannelCommand editChannelCommand)
    => await this.Mediator.Send(editChannelCommand);

    public async Task<GetChannelResponse> GetChannel(GetChannelCommand getChannelCommand)
    => await this.Mediator.Send(getChannelCommand);

    public async Task<ActionResult<SendChannelMessageResponse>> SendChannelMessage(SendChannelMessageCommand sendChannelMessageCommand)
        => await this.Mediator.Send(sendChannelMessageCommand);
}
