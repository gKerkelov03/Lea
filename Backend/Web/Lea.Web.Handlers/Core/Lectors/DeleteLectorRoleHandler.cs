using Lea.Services.Data.Interfaces.Core;
using Lea.Web.Commands.Core.Lectors;
using Lea.Web.Responses.Core.Lectors;
using MediatR;

namespace Lea.Web.Handlers.Core.Lectors;

public class DeleteLectorRoleHandler : IRequestHandler<DeleteLectorRoleCommand, DeleteLectorRoleResponse>
{
    private readonly ILectorsService groupsService;

    public DeleteLectorRoleHandler(ILectorsService groupsService)
        => this.groupsService = groupsService;

    public Task<DeleteLectorRoleResponse> Handle(DeleteLectorRoleCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}