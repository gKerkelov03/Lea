using Lea.Web.Commands.Core.Groups;
using Lea.Web.Commands.Core.Lectors;
using Lea.Web.Commands.Examination.Folders;
using Lea.Web.Responses.Core.Groups;
using Lea.Web.Responses.Core.Lectors;
using Lea.Web.Responses.Examination.Folders;
using Microsoft.AspNetCore.Mvc;

namespace Lea.Web.Controllers.Core;

public class LectorsController : ApiController
{       
    public async Task<ActionResult<DeleteLectorRoleResponse>> DeleteLectorRole(DeleteLectorRoleCommand deleteLectorRoleCommand)
        => await this.Mediator.Send(deleteLectorRoleCommand);
    
    public async Task<ActionResult<GetLectorResponse>> GetLector(GetLectorCommand getLectorCommand)
        => await this.Mediator.Send(getLectorCommand);
   
    public async Task<GetRootFolderResponse> GetRootFolder(GetRootFolderCommand getRootFolderCommand)
        => await this.Mediator.Send(getRootFolderCommand);

    public async Task<ActionResult<GetAllGroupsForALectorResponse>> GetAllGroups(GetAllGroupsForALectorCommand getAllGroupsCommand)
        => await this.Mediator.Send(getAllGroupsCommand);
}
