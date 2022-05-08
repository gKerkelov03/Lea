using MediatR;

namespace CQRS.Identity.Logout;

public class LogoutCommand : IRequest<LogoutResponse>
{
}
