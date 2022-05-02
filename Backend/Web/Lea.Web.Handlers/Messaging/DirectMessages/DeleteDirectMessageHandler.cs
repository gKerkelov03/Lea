using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Messaging.DirectMessages;
using Lea.Web.Responses.Examination.DirectMessages;
using MediatR;

namespace Lea.Web.Handlers.Messaging.DirectMessages;

public class DeleteDirectMessageHandler : IRequestHandler<DeleteDirectMessageCommand, DeleteDirectMessageResponse>
{
    private readonly IDirectMessagesService directMessagesService;

    public DeleteDirectMessageHandler(IDirectMessagesService directMessagesService)
        => this.directMessagesService = directMessagesService;

    public Task<DeleteDirectMessageResponse> Handle(DeleteDirectMessageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}