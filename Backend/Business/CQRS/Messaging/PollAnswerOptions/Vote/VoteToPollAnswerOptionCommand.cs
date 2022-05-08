using MediatR;

namespace CQRS.Messaging.PollAnswerOptions.Vote;

public class VoteToPollAnswerOptionCommand : IRequest<VoteToPollAnswerOptionResponse>
{
}