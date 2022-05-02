using Lea.Data.Entities.Identity;
using Lea.Web.Commands.Identity;
using Lea.Web.Responses.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Lea.Web.Handlers.Identity;

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
