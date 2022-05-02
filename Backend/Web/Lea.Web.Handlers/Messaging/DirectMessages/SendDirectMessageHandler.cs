using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Messaging.DirectMessages;
using Lea.Web.Responses.Examination.DirectMessages;
using MediatR;

namespace Lea.Web.Handlers.Messaging.DirectMessages;

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