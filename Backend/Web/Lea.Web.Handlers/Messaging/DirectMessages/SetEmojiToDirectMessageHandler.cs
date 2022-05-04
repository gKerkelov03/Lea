using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Messaging.Emojis;
using Lea.Web.Responses.Messaging.Emojis;
using MediatR;

namespace Lea.Web.Handlers.Messaging.Emojis;

public class SetEmojiToDirectMessageHandler : IRequestHandler<SetEmojiToDirectMessageCommand, SetEmojiToDirectMessageResponse>
{
    private readonly IEmojisService emojisService;

    public SetEmojiToDirectMessageHandler(IEmojisService emojisService)
        => this.emojisService = emojisService;

    public Task<SetEmojiToDirectMessageResponse> Handle(SetEmojiToDirectMessageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}