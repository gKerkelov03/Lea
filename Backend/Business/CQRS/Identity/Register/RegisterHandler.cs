using Data.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace CQRS.Identity.Register;

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