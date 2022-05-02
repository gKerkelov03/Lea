using Lea.Web.Responses.Identity;
using MediatR;

namespace Lea.Web.Commands.Identity;

public class LogoutCommand : IRequest<LogoutResponse>
{
}
