using CQRS.Core.Lectors.CreateFolder;
using CQRS.Core.Lectors.Delete;
using CQRS.Core.Lectors.Get;
using CQRS.Core.Lectors.GetAllGroups;
using CQRS.Core.Lectors.GetRootFolder;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Core;

public class LectorsController : ApiController
{
    //Lectors
    public async Task<ActionResult<DeleteLectorRoleResponse>> DeleteLectorRole(DeleteLectorRoleCommand deleteLectorRoleCommand)
        => await Mediator.Send(deleteLectorRoleCommand);

    public async Task<ActionResult<GetLectorResponse>> GetLector(GetLectorCommand getLectorCommand)
        => await Mediator.Send(getLectorCommand);


    //Groups
    public async Task<ActionResult<GetAllGroupsForALectorResponse>> GetAllGroups(GetAllGroupsForALectorCommand getAllGroupsCommand)
        => await Mediator.Send(getAllGroupsCommand);


    //Folders
    public async Task<ActionResult<CreateFolderResponse>> CreateFolder(CreateFolderCommand createFolderCommand)
        => await Mediator.Send(createFolderCommand);

    public async Task<GetRootFolderResponse> GetRootFolder(GetRootFolderCommand getRootFolderCommand)
        => await Mediator.Send(getRootFolderCommand);
}
