using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Messaging.PollAnswerOptions;
using Lea.Web.Responses.Messaging.PollAnswerOptions;
using MediatR;

namespace Lea.Web.Handlers.Messaging.PollAnswerOptions;

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