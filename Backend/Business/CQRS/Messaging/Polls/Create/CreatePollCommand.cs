using MediatR;

namespace CQRS.Messaging.Polls.Create;

public class CreatePollCommand : IRequest<CreatePollReponse>
{
}