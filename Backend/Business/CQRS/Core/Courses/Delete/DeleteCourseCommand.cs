using MediatR;

namespace CQRS.Core.Courses.Delete;

public class DeleteCourseCommand : IRequest<DeleteCourseResponse>
{
}