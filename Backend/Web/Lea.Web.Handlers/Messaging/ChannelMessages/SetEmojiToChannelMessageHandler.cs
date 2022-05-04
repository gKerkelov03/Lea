using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Messaging.ChannelMessages;
using Lea.Web.Commands.Messaging.Channels;
using Lea.Web.Responses.Messaging.ChannelMessages;
using Lea.Web.Responses.Messaging.Channels;
using MediatR;

namespace Lea.Web.Handlers.Messaging.Channels;

public class SetEmojiToChannelMessageHandler : IRequestHandler<SetEmojiToChannelMessageCommand, SetEmojiToChannelMessageResponse>
{
    private readonly IChannelsService channelsService;

    public SetEmojiToChannelMessageHandler(IChannelsService channelsService)
        => this.channelsService = channelsService;

    public Task<SetEmojiToChannelMessageResponse> Handle(SetEmojiToChannelMessageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}