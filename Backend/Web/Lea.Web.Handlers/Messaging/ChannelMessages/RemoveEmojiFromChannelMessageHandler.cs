using Lea.Services.Interfaces.Data.Messaging;
using Lea.Web.Commands.Messaging.ChannelMessages;
using Lea.Web.Responses.Messaging.ChannelMessages;
using MediatR;

namespace Lea.Web.Handlers.Messaging.ChannelMessages;

public class RemoveEmojiFromChannelMessageHandler : IRequestHandler<RemoveEmojiFromChannelMessageCommand, RemoveEmojiFromChannelMessageResponse>
{
    private readonly IChannelsService channelsService;

    public RemoveEmojiFromChannelMessageHandler(IChannelsService channelsService)
        => this.channelsService = channelsService;

    public Task<RemoveEmojiFromChannelMessageResponse> Handle(RemoveEmojiFromChannelMessageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}