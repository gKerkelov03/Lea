using CQRS.Messaging.PollAnswerOptions.RemoveVote;
using CQRS.Messaging.PollAnswerOptions.Vote;

namespace API.Controllers.Messaging;

public class PollAnswerOptionsController : ApiController
{
    public async Task<VoteToPollAnswerOptionResponse> VoteTo(VoteToPollAnswerOptionCommand voteToPollAnswerOptionCommand)
        => await Mediator.Send(voteToPollAnswerOptionCommand);

    public async Task<RemoveVoteFromPollAnswerOptionResponse> RemoveVoteFrom(RemoveVoteFromPollAnswerOptionCommand removeVoteFromPollAnswerOptionCommand)
        => await Mediator.Send(removeVoteFromPollAnswerOptionCommand);
}
