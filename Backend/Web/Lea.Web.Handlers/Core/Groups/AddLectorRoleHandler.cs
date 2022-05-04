using Lea.Services.Data.Interfaces.Core;
using Lea.Web.Commands.Core.Lectors;
using Lea.Web.Responses.Core.Lectors;
using MediatR;

namespace Lea.Web.Handlers.Core.Lectors;

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