using Lea.Services.Data.Interfaces.Core;
using Lea.Web.Commands.Core.Courses;
using Lea.Web.Responses.Core.Courses;
using MediatR;

namespace Lea.Web.Handlers.Core.Courses;

public class DeleteCourseHandler : IRequestHandler<DeleteCourseCommand, DeleteCourseResponse>
{
    private readonly ICoursesService coursesService;

    public DeleteCourseHandler(ICoursesService coursesService)
        => this.coursesService = coursesService;

    public Task<DeleteCourseResponse> Handle(DeleteCourseCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}