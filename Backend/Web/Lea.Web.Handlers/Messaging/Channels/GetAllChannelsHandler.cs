using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Messaging.Channels;
using Lea.Web.Responses.Messaging.Channels;
using MediatR;

namespace Lea.Web.Handlers.Messaging.Channels;

public class GetAllChannelsHandler : IRequestHandler<GetAllChannelsCommand, GetAllChannelsResponse>
{
    private readonly IChannelsService channelsService;

    public GetAllChannelsHandler(IChannelsService channelsService)
        => this.channelsService = channelsService;

    public Task<GetAllChannelsResponse> Handle(GetAllChannelsCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}