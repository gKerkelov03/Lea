using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Messaging.ChannelMessages;
using Lea.Web.Commands.Messaging.Channels;
using Lea.Web.Responses.Messaging.ChannelMessages;
using Lea.Web.Responses.Messaging.Channels;
using MediatR;

namespace Lea.Web.Handlers.Messaging.Channels;

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