using Lea.Web.Commands.Messaging.PollQuestions;
using Lea.Web.Responses.Messaging.PollQuestions;

namespace Lea.Web.Controllers.Messaging;

public class PollAnswerOptionsController : ApiController
{
    public async Task<VoteToPollAnswerOptionResponse> VoteToPollQuestion(VoteToPollAnswerOptionCommand voteToPollAnswerOptionCommand)
    => await this.Mediator.Send(voteToPollAnswerOptionCommand);

    public async Task<RemoveVoteFromPollAnswerOptionResponse> RemoveVoteFromPollQuestion(RemoveVoteFromPollAnswerOptionCommand removeVoteFromPollAnswerOptionCommand)
    => await this.Mediator.Send(removeVoteFromPollAnswerOptionCommand);
}
