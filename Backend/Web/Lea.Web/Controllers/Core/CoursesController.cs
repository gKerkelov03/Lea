using Lea.Web.Commands.Core.Courses;
using Lea.Web.Responses.Core.Courses;

namespace Lea.Web.Controllers.Core;

public class CoursesController : ApiController
{
    public async Task<CreateCourseResponse> CreateCourse(CreateCourseCommand createCourseCommand)
        => await this.Mediator.Send(createCourseCommand);
    
    public async Task<GetAllCoursesResponse> GetAll(GetAllCoursesCommand getAllCoursesCommand)    
        => await this.Mediator.Send(getAllCoursesCommand);
       
    public async Task<DeleteCourseResponse> DeleteCourse(DeleteCourseCommand deleteCourse)
        => await this.Mediator.Send(deleteCourse);

    public async Task<ChangeCourseBackgroundImageResponse> ChangeCourseBackgroundImage(ChangeCourseBackgroundImageCommand changeCourseBackgroundImageCommand)
        => await this.Mediator.Send(changeCourseBackgroundImageCommand);
}
