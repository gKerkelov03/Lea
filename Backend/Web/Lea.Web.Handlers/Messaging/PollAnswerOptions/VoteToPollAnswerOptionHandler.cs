using Lea.Services.Interfaces.Data.Messaging;
using Lea.Web.Commands.Messaging.PollAnswerOptions;
using Lea.Web.Responses.Messaging.PollAnswerOptions;
using MediatR;

namespace Lea.Web.Handlers.Messaging.PollAnswerOptions;

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