using Lea.Services.Data.Interfaces.Core;
using Lea.Web.Commands.Core.Students;
using Lea.Web.Responses.Core.Students;
using MediatR;

namespace Lea.Web.Handlers.Core.Students;

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