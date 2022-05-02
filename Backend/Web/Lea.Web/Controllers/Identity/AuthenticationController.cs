using Lea.Web.Commands.Identity;
using Lea.Web.Responses.Identity;

namespace Lea.Web.Controllers.Identity;

public class AuthenticationController : ApiController
{
    public async Task<LoginResponse> Login(LoginCommand loginCommand)
        => await this.Mediator.Send(loginCommand);

    public async Task LogoutAsync()
        => await this.Mediator.Send(new LogoutCommand());

    public async Task<RegisterResponse> Register(RegisterCommand registerCommand)
        => await this.Mediator.Send(registerCommand);
}
