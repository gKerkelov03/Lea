using Lea.Services.Interfaces.Data.Messaging;
using Lea.Web.Commands.Messaging.DirectMessages;
using Lea.Web.Responses.Messaging.DirectMessages;
using MediatR;

namespace Lea.Web.Handlers.Messaging.DirectMessages;

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