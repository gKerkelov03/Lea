using Lea.Services.Interfaces.Data.Core;
using Lea.Web.Commands.Core.Groups;
using Lea.Web.Responses.Core.Groups;
using MediatR;

namespace Lea.Web.Handlers.Core.Groups;

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