using Business.Interfaces.Data.Messaging;
using MediatR;

namespace CQRS.Core.Groups.CreateChannel;

public class CreateChannelHandler : IRequestHandler<CreateChannelCommand, CreateChannelResponse>
{
    private readonly IChannelsService channelsService;

    public CreateChannelHandler(IChannelsService channelsService)
        => this.channelsService = channelsService;

    public Task<CreateChannelResponse> Handle(CreateChannelCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}