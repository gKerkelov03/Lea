using MediatR;

namespace CQRS.Messaging.DirectMessages.Delete;

public class DeleteDirectMessageCommand : IRequest<DeleteDirectMessageResponse>
{
}