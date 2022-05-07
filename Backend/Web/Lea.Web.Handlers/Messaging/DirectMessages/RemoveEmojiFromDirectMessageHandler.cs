using Lea.Services.Interfaces.Data.Messaging;
using Lea.Web.Commands.Messaging.DirectMessages;
using Lea.Web.Responses.Messaging.DirectMessages;
using MediatR;

namespace Lea.Web.Handlers.Messaging.DirectMessages;

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