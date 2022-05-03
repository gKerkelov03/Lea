using Lea.Web.Commands.Messaging.PollAnswerOptions;
using Lea.Web.Responses.Messaging.PollAnswerOptions;

namespace Lea.Web.Controllers.Messaging;

public class PollAnswerOptionsController : ApiController
{
    public async Task<VoteToPollAnswerOptionResponse> VoteTo(VoteToPollAnswerOptionCommand voteToPollAnswerOptionCommand)
        => await this.Mediator.Send(voteToPollAnswerOptionCommand);

    public async Task<RemoveVoteFromPollAnswerOptionResponse> RemoveVoteFrom(RemoveVoteFromPollAnswerOptionCommand removeVoteFromPollAnswerOptionCommand)
        => await this.Mediator.Send(removeVoteFromPollAnswerOptionCommand);
}
