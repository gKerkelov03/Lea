using Lea.Services.Interfaces.Data.Core;
using Lea.Web.Commands.Core.Courses;
using Lea.Web.Responses.Core.Courses;
using MediatR;

namespace Lea.Web.Handlers.Core.Courses;

public class ChangeCourseBackgroundImageHandler : IRequestHandler<ChangeCourseBackgroundImageCommand, ChangeCourseBackgroundImageResponse>
{
    private readonly ICoursesService coursesService;

    public ChangeCourseBackgroundImageHandler(ICoursesService coursesService) 
        => this.coursesService = coursesService;

    public Task<ChangeCourseBackgroundImageResponse> Handle(ChangeCourseBackgroundImageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}