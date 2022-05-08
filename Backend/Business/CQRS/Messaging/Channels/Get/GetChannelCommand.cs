using MediatR;

namespace CQRS.Messaging.Channels.Get;

public class GetChannelCommand : IRequest<GetChannelResponse>
{
}