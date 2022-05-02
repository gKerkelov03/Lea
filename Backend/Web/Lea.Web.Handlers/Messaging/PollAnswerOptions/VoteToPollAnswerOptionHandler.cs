using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Messaging.PollQuestions;
using Lea.Web.Responses.Messaging.PollQuestions;
using MediatR;

namespace Lea.Web.Handlers.Messaging.PollQuestions;

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