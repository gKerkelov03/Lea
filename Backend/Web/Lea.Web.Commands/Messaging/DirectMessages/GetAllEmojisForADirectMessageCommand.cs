using Lea.Web.Responses.Messaging.DirectMessages;
using MediatR;

namespace Lea.Web.Commands.Messaging.DirectMessages;

public class GetAllEmojisForADirectMessageCommand : IRequest<GetAllEmojisForADirectMessageResponse>
{
}