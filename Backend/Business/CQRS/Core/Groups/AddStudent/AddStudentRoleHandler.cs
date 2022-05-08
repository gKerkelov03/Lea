using Business.Interfaces.Data.Core;
using MediatR;

namespace CQRS.Core.Groups.AddStudent;

public class AddStudentRoleHandler : IRequestHandler<AddStudentRoleCommand, AddStudentRoleResponse>
{
    private readonly IStudentsService groupsService;

    public AddStudentRoleHandler(IStudentsService groupsService)
        => this.groupsService = groupsService;

    public Task<AddStudentRoleResponse> Handle(AddStudentRoleCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}