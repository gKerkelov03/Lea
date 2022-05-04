using Lea.Services.Data.Interfaces.Core;
using Lea.Web.Commands.Core.Groups;
using Lea.Web.Responses.Core.Groups;
using MediatR;

namespace Lea.Web.Handlers.Core.Courses;

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