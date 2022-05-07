using Lea.Services.Interfaces.Data.Core;
using Lea.Web.Commands.Core.Students;
using Lea.Web.Responses.Core.Students;
using MediatR;

namespace Lea.Web.Handlers.Core.Students;

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