using Business.Interfaces.Data.Core;
using MediatR;

namespace CQRS.Core.Groups.GetAllStudents;

public class GetAllStudentsForAGroupHandler : IRequestHandler<GetAllStudentsForAGroupCommand, GetAllStudentsForAGroupResponse>
{
    private readonly IStudentsService groupsService;

    public GetAllStudentsForAGroupHandler(IStudentsService groupsService)
        => this.groupsService = groupsService;

    public Task<GetAllStudentsForAGroupResponse> Handle(GetAllStudentsForAGroupCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}