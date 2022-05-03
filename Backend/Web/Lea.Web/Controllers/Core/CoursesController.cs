﻿using Lea.Web.Commands.Core.Courses;
using Lea.Web.Commands.Core.Groups;
using Lea.Web.Responses.Core.Courses;
using Lea.Web.Responses.Core.Groups;
using Microsoft.AspNetCore.Mvc;

namespace Lea.Web.Controllers.Core;

public class CoursesController : ApiController
{
    public async Task<ActionResult<CreateCourseResponse>> CreateCourse(CreateCourseCommand createCourseCommand)
        => await this.Mediator.Send(createCourseCommand);            
       
    public async Task<ActionResult<DeleteCourseResponse>> DeleteCourse(DeleteCourseCommand deleteCourse)
        => await this.Mediator.Send(deleteCourse);

    public async Task<ActionResult<ChangeCourseBackgroundImageResponse>> ChangeCourseBackgroundImage(ChangeCourseBackgroundImageCommand changeCourseBackgroundImageCommand)
        => await this.Mediator.Send(changeCourseBackgroundImageCommand);

    public async Task<ActionResult<CreateGroupResponse>> CreateGroup(CreateGroupCommand createGroupCommand)
        => await this.Mediator.Send(createGroupCommand);

    public async Task<ActionResult<GetAllGroupsForACourseResponse>> GetAllGroups(GetAllGroupsForACourseCommand getAllGroupsCommand)
        => await this.Mediator.Send(getAllGroupsCommand);
}
