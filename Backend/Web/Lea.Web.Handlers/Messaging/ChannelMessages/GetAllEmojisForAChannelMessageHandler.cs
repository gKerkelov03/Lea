using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Messaging.ChannelMessages;
using Lea.Web.Commands.Messaging.Channels;
using Lea.Web.Responses.Messaging.ChannelMessages;
using Lea.Web.Responses.Messaging.Channels;
using MediatR;

namespace Lea.Web.Handlers.Messaging.Channels;

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