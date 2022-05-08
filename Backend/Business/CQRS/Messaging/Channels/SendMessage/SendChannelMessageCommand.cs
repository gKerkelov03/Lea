using MediatR;

namespace CQRS.Messaging.Channels.SendMessage;

public class SendChannelMessageCommand : IRequest<SendChannelMessageResponse>
{
}