using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Messaging.ChannelMessages;
using Lea.Web.Responses.Messaging.ChannelMessages;
using MediatR;

namespace Lea.Web.Handlers.Messaging.ChannelMessages;

public class GetChannelMessageHandler : IRequestHandler<GetChannelMessageCommand, GetChannelMessageResponse>
{
    private readonly IChannelMessagesService channelMessagesService;

    public GetChannelMessageHandler(IChannelMessagesService channelMessagesService)
        => this.channelMessagesService = channelMessagesService;

    public Task<GetChannelMessageResponse> Handle(GetChannelMessageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}