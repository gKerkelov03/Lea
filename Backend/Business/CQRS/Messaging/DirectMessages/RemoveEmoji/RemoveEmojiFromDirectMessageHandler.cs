using Business.Interfaces.Data.Messaging;
using MediatR;

namespace CQRS.Messaging.DirectMessages.RemoveEmoji;

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