using Lea.Services.Interfaces.Data.Core;
using Lea.Web.Commands.Core.Groups;
using Lea.Web.Responses.Core.Groups;
using MediatR;

namespace Lea.Web.Handlers.Core.Groups;

public class AddLectorRoleHandler : IRequestHandler<AddLectorRoleCommand, AddLectorRoleResponse>
{
    private readonly ILectorsService groupsService;

    public AddLectorRoleHandler(ILectorsService groupsService)
        => this.groupsService = groupsService;

    public Task<AddLectorRoleResponse> Handle(AddLectorRoleCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}