using MediatR;

namespace CQRS.Messaging.Channels.Edit;

public class EditChannelCommand : IRequest<EditChannelResponse>
{
}