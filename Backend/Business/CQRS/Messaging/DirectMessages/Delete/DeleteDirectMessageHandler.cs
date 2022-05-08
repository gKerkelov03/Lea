using Business.Interfaces.Data.Messaging;
using MediatR;

namespace CQRS.Messaging.DirectMessages.Delete;

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