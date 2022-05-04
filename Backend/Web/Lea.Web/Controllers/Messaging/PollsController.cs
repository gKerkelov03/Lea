using Lea.Web.Commands.Messaging.Polls;
using Lea.Web.Responses.Messaging.Polls;

namespace Lea.Web.Controllers.Messaging;
public class PollsController : ApiController
{
    public async Task<CreatePollReponse> CreatePoll(CreatePollCommand createPollCommand)
    => await this.Mediator.Send(createPollCommand);

    public async Task<GetPollReponse> GetPoll(GetPollCommand getPollCommand)
    => await this.Mediator.Send(getPollCommand);    
}
