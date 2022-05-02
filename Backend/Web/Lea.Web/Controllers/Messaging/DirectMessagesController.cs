using Lea.Web.Commands.Messaging.DirectMessages;
using Lea.Web.Responses.Examination.DirectMessages;

namespace Lea.Web.Controllers.Messaging;

public class DirectMessagesController : ApiController
{
    public async Task<SendDirectMessageResponse> SendDirectMessage(SendDirectMessageCommand sendDirectMessageCommand)
    => await this.Mediator.Send(sendDirectMessageCommand);

    public async Task<DeleteDirectMessageResponse> DeleteDirectMessage(DeleteDirectMessageCommand deleteDirectMessageCommand)
    => await this.Mediator.Send(deleteDirectMessageCommand);
}
