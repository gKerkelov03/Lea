using MediatR;

namespace CQRS.Messaging.DirectMessages.SendMessage;

public class SendDirectMessageCommand : IRequest<SendDirectMessageResponse>
{
}