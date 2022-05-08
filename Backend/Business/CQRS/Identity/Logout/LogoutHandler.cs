using Data.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace CQRS.Identity.Logout;

public class LogoutHandler : IRequestHandler<LogoutCommand, LogoutResponse>
{
    private readonly UserManager<LeaUser> userManager;

    public LogoutHandler(UserManager<LeaUser> userManager)
        => this.userManager = userManager;

    public Task<LogoutResponse> Handle(LogoutCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}