using Business.Interfaces.Data.Core;
using MediatR;

namespace CQRS.Core.Lectors.GetAllGroups;

public class GetAllGroupsHandler : IRequestHandler<GetAllGroupsForALectorCommand, GetAllGroupsForALectorResponse>
{
    private readonly ILectorsService groupsService;

    public GetAllGroupsHandler(ILectorsService groupsService)
        => this.groupsService = groupsService;

    public Task<GetAllGroupsForALectorResponse> Handle(GetAllGroupsForALectorCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}