using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Messaging.Emojis;
using Lea.Web.Responses.Messaging.Emojis;
using MediatR;

namespace Lea.Web.Handlers.Messaging.Emojis;

public class RemoveEmojiFromDirectMessageHandler : IRequestHandler<RemoveEmojiFromDirectMessageCommand, RemoveEmojiFromDirectMessageResponse>
{
    private readonly IEmojisService emojisService;

    public RemoveEmojiFromDirectMessageHandler(IEmojisService emojisService)
        => this.emojisService = emojisService;

    public Task<RemoveEmojiFromDirectMessageResponse> Handle(RemoveEmojiFromDirectMessageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}