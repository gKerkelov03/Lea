using Business.Interfaces.Data.Messaging;
using MediatR;

namespace CQRS.Messaging.PollAnswerOptions.RemoveVote;

public class RemoveVoteFromPollAnswerOptionHandler : IRequestHandler<RemoveVoteFromPollAnswerOptionCommand, RemoveVoteFromPollAnswerOptionResponse>
{
    private readonly IPollAnswerOptionsService pollAnswerOptionsService;

    public RemoveVoteFromPollAnswerOptionHandler(IPollAnswerOptionsService pollAnswerOptionsService)
        => this.pollAnswerOptionsService = pollAnswerOptionsService;

    public Task<RemoveVoteFromPollAnswerOptionResponse> Handle(RemoveVoteFromPollAnswerOptionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}