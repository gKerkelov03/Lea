using CQRS.Core.Courses.AddAdmin;
using CQRS.Core.Courses.ChangeBackgroundImage;
using CQRS.Core.Courses.Create;
using CQRS.Core.Courses.CreateGroup;
using CQRS.Core.Courses.Delete;
using CQRS.Core.Courses.GetAllGroups;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Core;

public class CoursesController : ApiController
{
    //Courses
    public async Task<ActionResult<CreateCourseResponse>> CreateCourse(CreateCourseCommand createCourseCommand)
        => await Mediator.Send(createCourseCommand);

    public async Task<ActionResult<ChangeCourseBackgroundImageResponse>> ChangeCourseBackgroundImage(ChangeCourseBackgroundImageCommand changeCourseBackgroundImageCommand)
        => await Mediator.Send(changeCourseBackgroundImageCommand);

    public async Task<ActionResult<DeleteCourseResponse>> DeleteCourse(DeleteCourseCommand deleteCourse)
        => await Mediator.Send(deleteCourse);

    public async Task<ActionResult<AddAdminRoleResponse>> AddAdminRole(AddAdminRoleCommand addAdminRoleCommand)
        => await Mediator.Send(addAdminRoleCommand);

    //Groups
    public async Task<ActionResult<CreateGroupResponse>> CreateGroup(CreateGroupCommand createGroupCommand)
        => await Mediator.Send(createGroupCommand);

    public async Task<ActionResult<GetAllGroupsForACourseResponse>> GetAllGroups(GetAllGroupsForACourseCommand getAllGroupsCommand)
        => await Mediator.Send(getAllGroupsCommand);
}
