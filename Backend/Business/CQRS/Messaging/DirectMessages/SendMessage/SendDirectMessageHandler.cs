using Business.Interfaces.Data.Messaging;
using MediatR;

namespace CQRS.Messaging.DirectMessages.SendMessage;

public class SendDirectMessageHandler : IRequestHandler<SendDirectMessageCommand, SendDirectMessageResponse>
{
    private readonly IDirectMessagesService directMessagesService;

    public SendDirectMessageHandler(IDirectMessagesService directMessagesService)
        => this.directMessagesService = directMessagesService;

    public Task<SendDirectMessageResponse> Handle(SendDirectMessageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}