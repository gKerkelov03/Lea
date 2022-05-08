using CQRS.Messaging.Channels.Delete;
using CQRS.Messaging.Channels.Edit;
using CQRS.Messaging.Channels.Get;
using CQRS.Messaging.Channels.SendMessage;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Messaging;

public class ChannelsController : ApiController
{
    public async Task<DeleteChannelResponse> DeleteChannel(DeleteChannelCommand deleteChannelCommand)
    => await Mediator.Send(deleteChannelCommand);

    public async Task<EditChannelResponse> EditChannel(EditChannelCommand editChannelCommand)
    => await Mediator.Send(editChannelCommand);

    public async Task<GetChannelResponse> GetChannel(GetChannelCommand getChannelCommand)
    => await Mediator.Send(getChannelCommand);

    public async Task<ActionResult<SendChannelMessageResponse>> SendChannelMessage(SendChannelMessageCommand sendChannelMessageCommand)
        => await Mediator.Send(sendChannelMessageCommand);
}
