using MediatR;

namespace CQRS.Core.Courses.Create;

public class CreateCourseCommand : IRequest<CreateCourseResponse>
{
    public Guid DirectorId { get; set; }

    public string Name { get; set; }
}