using CQRS.Identity.Login;
using CQRS.Identity.Logout;
using CQRS.Identity.Register;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Identity;

public class AuthenticationController : ApiController
{
    public async Task<ActionResult<LoginResponse>> Login(LoginCommand loginCommand)
        => await Mediator.Send(loginCommand);

    public async Task Logout()
        => await Mediator.Send(new LogoutCommand());

    public async Task<ActionResult<RegisterResponse>> Register(RegisterCommand registerCommand)
        => await Mediator.Send(registerCommand);
}
