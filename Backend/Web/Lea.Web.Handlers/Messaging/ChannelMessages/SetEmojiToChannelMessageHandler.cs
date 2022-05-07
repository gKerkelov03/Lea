using Lea.Services.Interfaces.Data.Messaging;
using Lea.Web.Commands.Messaging.ChannelMessages;
using Lea.Web.Responses.Messaging.ChannelMessages;
using MediatR;

namespace Lea.Web.Handlers.Messaging.ChannelMessages;

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