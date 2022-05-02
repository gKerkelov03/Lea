using Lea.Web.Responses.Messaging.PollQuestions;
using MediatR;

namespace Lea.Web.Commands.Messaging.PollQuestions;

public class RemoveVoteFromPollAnswerOptionCommand : IRequest<RemoveVoteFromPollAnswerOptionResponse>
{
}