using Lea.Services.Interfaces.Data.Messaging;
using Lea.Web.Commands.Messaging.Channels;
using Lea.Web.Responses.Messaging.Channels;
using MediatR;

namespace Lea.Web.Handlers.Messaging.Channels;

public class EditChannelHandler : IRequestHandler<EditChannelCommand, EditChannelResponse>
{
    private readonly IChannelsService channelsService;

    public EditChannelHandler(IChannelsService channelsService)
        => this.channelsService = channelsService;

    public Task<EditChannelResponse> Handle(EditChannelCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}