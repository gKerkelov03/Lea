using CQRS.Messaging.Polls.Create;
using CQRS.Messaging.Polls.Get;

namespace API.Controllers.Messaging;
public class PollsController : ApiController
{
    public async Task<CreatePollReponse> CreatePoll(CreatePollCommand createPollCommand)
    => await Mediator.Send(createPollCommand);

    public async Task<GetPollReponse> GetPoll(GetPollCommand getPollCommand)
    => await Mediator.Send(getPollCommand);
}
