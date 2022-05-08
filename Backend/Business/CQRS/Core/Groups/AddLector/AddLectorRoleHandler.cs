using Business.Interfaces.Data.Core;
using MediatR;

namespace CQRS.Core.Groups.AddLector;

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