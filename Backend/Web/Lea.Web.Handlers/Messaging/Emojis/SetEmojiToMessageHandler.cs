using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Messaging.Emojis;
using Lea.Web.Responses.Messaging.Emojis;
using MediatR;

namespace Lea.Web.Handlers.Messaging.Emojis;

public class SetEmojiToMessageHandler : IRequestHandler<SetEmojiToMessageCommand, SetEmojiToMessageResponse>
{
    private readonly IEmojisService emojisService;

    public SetEmojiToMessageHandler(IEmojisService emojisService)
        => this.emojisService = emojisService;

    public Task<SetEmojiToMessageResponse> Handle(SetEmojiToMessageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}