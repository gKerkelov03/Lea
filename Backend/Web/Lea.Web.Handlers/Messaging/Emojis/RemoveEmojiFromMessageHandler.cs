using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Messaging.Emojis;
using Lea.Web.Responses.Messaging.Emojis;
using MediatR;

namespace Lea.Web.Handlers.Messaging.Emojis;

public class RemoveEmojiFromMessageHandler : IRequestHandler<RemoveEmojiFromMessageCommand, RemoveEmojiFromMessageResponse>
{
    private readonly IEmojisService emojisService;

    public RemoveEmojiFromMessageHandler(IEmojisService emojisService)
        => this.emojisService = emojisService;

    public Task<RemoveEmojiFromMessageResponse> Handle(RemoveEmojiFromMessageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}