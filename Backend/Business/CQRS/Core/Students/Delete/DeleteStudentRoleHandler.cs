using Business.Interfaces.Data.Core;
using MediatR;

namespace CQRS.Core.Students.Delete;

public class DeleteStudentRoleHandler : IRequestHandler<DeleteStudentRoleCommand, DeleteStudentRoleResponse>
{
    private readonly IStudentsService groupsService;

    public DeleteStudentRoleHandler(IStudentsService groupsService)
        => this.groupsService = groupsService;

    public Task<DeleteStudentRoleResponse> Handle(DeleteStudentRoleCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}