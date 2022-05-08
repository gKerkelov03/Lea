using Business.Interfaces.Data.Messaging;
using MediatR;

namespace CQRS.Messaging.Channels.Edit;

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