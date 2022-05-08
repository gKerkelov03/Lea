using Data.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace CQRS.Identity.Login;

public class LoginHandler : IRequestHandler<LoginCommand, LoginResponse>
{
    private readonly SignInManager<LeaUser> signInManager;

    public LoginHandler(SignInManager<LeaUser> signInManager)
        => this.signInManager = signInManager;

    public Task<LoginResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
