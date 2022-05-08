using MediatR;

namespace CQRS.Messaging.Emojis;

public class GetAllEmojisCommand : IRequest<GetAllEmojisResponse>
{
}