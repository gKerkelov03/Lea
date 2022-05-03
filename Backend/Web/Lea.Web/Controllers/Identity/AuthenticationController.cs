using Lea.Web.Commands.Identity;
using Lea.Web.Responses.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Lea.Web.Controllers.Identity;

public class AuthenticationController : ApiController
{
    public async Task<ActionResult<LoginResponse>> Login(LoginCommand loginCommand)
        => await this.Mediator.Send(loginCommand);

    public async Task Logout()
        => await this.Mediator.Send(new LogoutCommand());

    public async Task<ActionResult<RegisterResponse>> Register(RegisterCommand registerCommand)
        => await this.Mediator.Send(registerCommand);
}
