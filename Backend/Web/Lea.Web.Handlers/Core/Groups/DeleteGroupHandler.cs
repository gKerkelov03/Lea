using Lea.Services.Data.Interfaces.Core;
using Lea.Web.Commands.Core.Groups;
using Lea.Web.Responses.Core.Groups;
using MediatR;

namespace Lea.Web.Handlers.Core.Groups;

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