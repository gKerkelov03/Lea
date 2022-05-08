using MediatR;

namespace CQRS.Core.Courses.AddAdmin;

public class AddAdminRoleCommand : IRequest<AddAdminRoleResponse>
{
    public Guid CourseId { get; set; }

    public Guid UserId { get; set; }
}