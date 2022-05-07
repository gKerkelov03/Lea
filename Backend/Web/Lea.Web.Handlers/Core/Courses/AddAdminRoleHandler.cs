using Lea.Services.Interfaces.Data.Core;
using Lea.Web.Commands.Core.Courses;
using Lea.Web.Responses.Core.Courses;
using MediatR;

namespace Lea.Web.Handlers.Core.Courses;

public class AddAdminRoleHandler : IRequestHandler<AddAdminRoleCommand, AddAdminRoleResponse>
{
    private readonly ICoursesService coursesService;

    public AddAdminRoleHandler(ICoursesService coursesService)
        => this.coursesService = coursesService;

    public Task<AddAdminRoleResponse> Handle(AddAdminRoleCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}