using MediatR;

namespace CQRS.Messaging.Polls.Get;

public class GetPollCommand : IRequest<GetPollReponse>
{
}