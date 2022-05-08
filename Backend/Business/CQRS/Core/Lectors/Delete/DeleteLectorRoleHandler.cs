using Business.Interfaces.Data.Core;
using MediatR;

namespace CQRS.Core.Lectors.Delete;

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