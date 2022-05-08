using Business.Interfaces.Data.Core;
using MediatR;

namespace CQRS.Core.Courses.ChangeBackgroundImage;

public class ChangeCourseBackgroundImageHandler : IRequestHandler<ChangeCourseBackgroundImageCommand, ChangeCourseBackgroundImageResponse>
{
    private readonly ICoursesService coursesService;

    public ChangeCourseBackgroundImageHandler(ICoursesService coursesService)
        => this.coursesService = coursesService;

    public async Task<ChangeCourseBackgroundImageResponse> Handle(ChangeCourseBackgroundImageCommand request, CancellationToken cancellationToken)
    {
        var course = await coursesService.GetByIdAsync(request.CourseId);

        if (course == null)
        {
            return new ChangeCourseBackgroundImageResponse() { Success = false };
        }

        course.PictureUrl = request.PictureUrl;

        return new ChangeCourseBackgroundImageResponse() { Success = true };
    }
}