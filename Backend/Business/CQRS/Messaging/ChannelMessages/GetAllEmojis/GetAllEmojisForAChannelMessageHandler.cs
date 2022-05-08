using Business.Interfaces.Data.Messaging;
using MediatR;

namespace CQRS.Messaging.ChannelMessages.GetAllEmojis;

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