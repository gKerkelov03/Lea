using Lea.Web.Commands.Core.Lectors;
using Lea.Web.Responses.Core.Lectors;
using Microsoft.AspNetCore.Mvc;

namespace Lea.Web.Controllers.Core;

public class LectorsController : ApiController
{   
    //Lectors
    public async Task<ActionResult<DeleteLectorRoleResponse>> DeleteLectorRole(DeleteLectorRoleCommand deleteLectorRoleCommand)
        => await this.Mediator.Send(deleteLectorRoleCommand);
    
    public async Task<ActionResult<GetLectorResponse>> GetLector(GetLectorCommand getLectorCommand)
        => await this.Mediator.Send(getLectorCommand);
   

    //Groups
    public async Task<ActionResult<GetAllGroupsForALectorResponse>> GetAllGroups(GetAllGroupsForALectorCommand getAllGroupsCommand)
        => await this.Mediator.Send(getAllGroupsCommand);


    //Folders
    public async Task<ActionResult<CreateFolderResponse>> CreateFolder(CreateFolderCommand createFolderCommand)
        => await this.Mediator.Send(createFolderCommand);

    public async Task<GetRootFolderResponse> GetRootFolder(GetRootFolderCommand getRootFolderCommand)
        => await this.Mediator.Send(getRootFolderCommand);
}
