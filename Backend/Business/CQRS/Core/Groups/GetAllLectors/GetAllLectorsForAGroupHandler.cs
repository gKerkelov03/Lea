using Business.Interfaces.Data.Core;
using MediatR;

namespace CQRS.Core.Groups.GetAllLectors;

public class GetAllLectorsHandler : IRequestHandler<GetAllLectorsForAGroupCommand, GetAllLectorsForAGroupResponse>
{
    private readonly ILectorsService groupsService;

    public GetAllLectorsHandler(ILectorsService groupsService)
        => this.groupsService = groupsService;

    public Task<GetAllLectorsForAGroupResponse> Handle(GetAllLectorsForAGroupCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}