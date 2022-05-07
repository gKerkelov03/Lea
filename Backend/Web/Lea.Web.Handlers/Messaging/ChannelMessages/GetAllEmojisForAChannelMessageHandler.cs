using Lea.Services.Interfaces.Data.Messaging;
using Lea.Web.Commands.Messaging.ChannelMessages;
using Lea.Web.Responses.Messaging.ChannelMessages;
using MediatR;

namespace Lea.Web.Handlers.Messaging.ChannelMessages;

public class GetAllEmojisForAChannelMessageHandler : IRequestHandler<GetAllEmojisForAChannelMessageCommand, GetAllEmojisForAChannelMessageResponse>
{
    private readonly IChannelsService channelsService;

    public GetAllEmojisForAChannelMessageHandler(IChannelsService channelsService)
        => this.channelsService = channelsService;

    public Task<GetAllEmojisForAChannelMessageResponse> Handle(GetAllEmojisForAChannelMessageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}