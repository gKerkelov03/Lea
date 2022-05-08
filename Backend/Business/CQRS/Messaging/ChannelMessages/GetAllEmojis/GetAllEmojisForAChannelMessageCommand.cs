using MediatR;

namespace CQRS.Messaging.ChannelMessages.GetAllEmojis;

public class GetAllEmojisForAChannelMessageCommand : IRequest<GetAllEmojisForAChannelMessageResponse>
{
}