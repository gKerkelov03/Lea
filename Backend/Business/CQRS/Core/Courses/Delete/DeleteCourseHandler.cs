using Business.Interfaces.Data.Core;
using MediatR;

namespace CQRS.Core.Courses.Delete;

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