using Business.Interfaces.Data.Core;
using MediatR;

namespace CQRS.Core.Groups.Delete;

public class DeleteGroupHandler : IRequestHandler<DeleteGroupCommand, DeleteGroupResponse>
{
    private readonly IGroupsService groupsService;

    public DeleteGroupHandler(IGroupsService groupsService)
        => this.groupsService = groupsService;

    public Task<DeleteGroupResponse> Handle(DeleteGroupCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}