using Business.Interfaces.Data.Core;
using MediatR;
using Services.Data.Models.Core;

namespace CQRS.Core.Courses.Create;

public class CreateCourseHandler : IRequestHandler<CreateCourseCommand, CreateCourseResponse>
{
    private readonly ICoursesService coursesService;

    public CreateCourseHandler(ICoursesService coursesService)
        => this.coursesService = coursesService;

    public Task<CreateCourseResponse> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
    {
        var newCourse = new CourseServiceModel
        {
            Name = request.Name,
            DirectorId = request.DirectorId,
        };

        coursesService.Create(newCourse);

        return Task.FromResult(new CreateCourseResponse { Success = true });
    }
}