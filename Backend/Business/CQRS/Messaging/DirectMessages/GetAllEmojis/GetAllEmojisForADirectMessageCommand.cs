using MediatR;

namespace CQRS.Messaging.DirectMessages.GetAllEmojis;

public class GetAllEmojisForADirectMessageCommand : IRequest<GetAllEmojisForADirectMessageResponse>
{
}