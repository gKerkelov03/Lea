using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Messaging.PollQuestions;
using Lea.Web.Responses.Messaging.PollQuestions;
using MediatR;

namespace Lea.Web.Handlers.Messaging.PollQuestions;

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