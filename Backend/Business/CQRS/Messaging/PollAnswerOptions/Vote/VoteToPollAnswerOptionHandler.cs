using Business.Interfaces.Data.Messaging;
using MediatR;

namespace CQRS.Messaging.PollAnswerOptions.Vote;

public class VoteToPollAnswerOptionHandler : IRequestHandler<VoteToPollAnswerOptionCommand, VoteToPollAnswerOptionResponse>
{
    private readonly IPollAnswerOptionsService pollAnswerOptionsService;

    public VoteToPollAnswerOptionHandler(IPollAnswerOptionsService pollAnswerOptionsService)
        => this.pollAnswerOptionsService = pollAnswerOptionsService;

    public Task<VoteToPollAnswerOptionResponse> Handle(VoteToPollAnswerOptionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}