using Business.Interfaces.Data.Core;
using MediatR;

namespace CQRS.Core.Courses.CreateGroup;

public class CreateGroupHandler : IRequestHandler<CreateGroupCommand, CreateGroupResponse>
{
    private readonly IGroupsService groupsService;

    public CreateGroupHandler(IGroupsService groupsService)
        => this.groupsService = groupsService;

    public Task<CreateGroupResponse> Handle(CreateGroupCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}