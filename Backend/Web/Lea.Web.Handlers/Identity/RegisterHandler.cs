using Lea.Data.Entities.Identity;
using Lea.Web.Commands.Identity;
using Lea.Web.Responses.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Lea.Web.Handlers.Identity;

public class RegisterHandler : IRequestHandler<RegisterCommand, RegisterResponse>
{
    private readonly UserManager<LeaUser> userManager;

    public RegisterHandler(UserManager<LeaUser> userManager)
    {
        this.userManager = userManager;
    }

    public Task<RegisterResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}