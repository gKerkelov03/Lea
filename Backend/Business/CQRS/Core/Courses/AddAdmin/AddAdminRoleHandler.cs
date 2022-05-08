using Business.Interfaces.Data.Core;
using Data.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using static Common.GlobalConstants;

namespace CQRS.Core.Courses.AddAdmin;

public class AddAdminRoleHandler : IRequestHandler<AddAdminRoleCommand, AddAdminRoleResponse>
{
    private readonly ICoursesService coursesService;
    private readonly UserManager<LeaUser> userManager;
    private readonly RoleManager<LeaRole> roleManager;

    public AddAdminRoleHandler(ICoursesService coursesService, UserManager<LeaUser> userManager, RoleManager<LeaRole> roleManager)
    {
        this.coursesService = coursesService;
        this.userManager = userManager;
        this.roleManager = roleManager;
    }

    public async Task<AddAdminRoleResponse> Handle(AddAdminRoleCommand request, CancellationToken cancellationToken)
    {
        var role = roleManager.Roles.Where(role => role.Course.Id == request.CourseId && role.Name == adminRoleName).FirstOrDefault();

        if (role is null)
        {
            role = new LeaRole()
            {
                CourseId = request.CourseId,
                Name = adminRoleName,
            };

            await roleManager.CreateAsync(role);
        }

        var user = await userManager.FindByIdAsync(request.UserId.ToString());

        if (!user.Roles.Any(r => r == role))
        {
            user.Roles.Add(role);
        }

        return new AddAdminRoleResponse
        {
            Success = true
        };
    }
}