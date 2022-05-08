using MediatR;

namespace CQRS.Identity.Login;

public class LoginCommand : IRequest<LoginResponse>
{
}
