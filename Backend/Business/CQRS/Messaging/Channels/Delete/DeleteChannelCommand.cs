using MediatR;

namespace CQRS.Messaging.Channels.Delete;

public class DeleteChannelCommand : IRequest<DeleteChannelResponse>
{
}