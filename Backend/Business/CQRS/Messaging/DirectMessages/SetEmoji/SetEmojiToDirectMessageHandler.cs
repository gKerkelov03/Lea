using Business.Interfaces.Data.Messaging;
using MediatR;

namespace CQRS.Messaging.DirectMessages.SetEmoji;

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