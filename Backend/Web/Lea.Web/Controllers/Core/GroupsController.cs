using Lea.Web.Commands.Core.Groups;
using Lea.Web.Responses.Core.Groups;

namespace Lea.Web.Controllers.Core;

public class GroupsController : ApiController
{
    public async Task<CreateGroupResponse> CreateGroup(CreateGroupCommand createGroupCommand)
        => await this.Mediator.Send(createGroupCommand);

    public async Task<GetAllGroupsResponse> GetAllGroups(GetAllGroupsCommand getAllGroupsCommand)
        => await this.Mediator.Send(getAllGroupsCommand);

    public async Task<ChangeGroupBackgroundImageResponse> ChangeBackgroundImage(ChangeGroupBackgroundImageCommand changeGroupBackgroundImageCommand)
        => await this.Mediator.Send(changeGroupBackgroundImageCommand);

    public async Task<DeleteGroupResponse> DeleteGroup(DeleteGroupCommand createGroupCommand)
        => await this.Mediator.Send(createGroupCommand);
}
