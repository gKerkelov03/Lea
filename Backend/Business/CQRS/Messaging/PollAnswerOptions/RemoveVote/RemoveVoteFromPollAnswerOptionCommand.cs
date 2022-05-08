using MediatR;

namespace CQRS.Messaging.PollAnswerOptions.RemoveVote;

public class RemoveVoteFromPollAnswerOptionCommand : IRequest<RemoveVoteFromPollAnswerOptionResponse>
{
}