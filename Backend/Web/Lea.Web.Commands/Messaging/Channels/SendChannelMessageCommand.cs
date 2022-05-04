using Lea.Web.Responses.Messaging.ChannelMessages;
using MediatR;

namespace Lea.Web.Commands.Messaging.ChannelMessages;

public class SendChannelMessageCommand : IRequest<SendChannelMessageResponse>
{
}