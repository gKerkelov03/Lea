using Lea.Data.Entities.Identity;
using Lea.Web.Commands.Identity;
using Lea.Web.Responses.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Lea.Web.Handlers.Identity;

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