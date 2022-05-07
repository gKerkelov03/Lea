using Lea.Services.Interfaces.Data.Messaging;
using Lea.Web.Commands.Core.Groups;
using Lea.Web.Responses.Core.Groups;
using MediatR;

namespace Lea.Web.Handlers.Core.Groups;

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