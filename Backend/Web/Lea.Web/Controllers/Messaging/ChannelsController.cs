using Lea.Web.Commands.Messaging.Channels;
using Lea.Web.Responses.Messaging.Channels;

namespace Lea.Web.Controllers.Messaging;

public class ChannelsController : ApiController
{
    public async Task<CreateChannelResponse> CreateChannel(CreateChannelCommand createChannelCommand)
    => await this.Mediator.Send(createChannelCommand);

    public async Task<DeleteChannelResponse> DeleteChannel(DeleteChannelCommand deleteChannelCommand)
    => await this.Mediator.Send(deleteChannelCommand);

    public async Task<EditChannelResponse> EditChannel(EditChannelCommand editChannelCommand)
    => await this.Mediator.Send(editChannelCommand);

    public async Task<GetChannelResponse> GetChannel(GetChannelCommand getChannelCommand)
    => await this.Mediator.Send(getChannelCommand);

    public async Task<GetAllChannelsResponse> GetAllChannels(GetAllChannelsCommand getAllChannelsCommand)
    => await this.Mediator.Send(getAllChannelsCommand);
}
