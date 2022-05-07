using Lea.Services.Interfaces.Data.Core;
using Lea.Web.Commands.Core.Courses;
using Lea.Web.Responses.Core.Courses;
using MediatR;

namespace Lea.Web.Handlers.Core.Courses;

public class CreateCourseHandler : IRequestHandler<CreateCourseCommand, CreateCourseResponse>
{
    private readonly ICoursesService coursesService;

    public CreateCourseHandler(ICoursesService coursesService)
        => this.coursesService = coursesService;

    public Task<CreateCourseResponse> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}