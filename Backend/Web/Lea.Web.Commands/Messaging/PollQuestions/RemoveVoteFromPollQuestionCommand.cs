using Lea.Web.Responses.Messaging.PollQuestions;
using MediatR;

namespace Lea.Web.Commands.Messaging.PollQuestions;

public class RemoveVoteFromPollQuestionCommand : IRequest<RemoveVoteFromPollQuestionResponse>
{
}