using Lea.Web.Commands.Examination.Folders;
using Lea.Web.Responses.Examination.Folders;

namespace Lea.Web.Controllers.Examination;

public class FoldersController : ApiController
{
    public async Task<CreateFolderResponse> CreateFolder(CreateFolderCommand createFolderCommand)
        => await this.Mediator.Send(createFolderCommand);

    public async Task<GetFolderResponse> GetFolder(GetFolderCommand getFolderCommand)
        => await this.Mediator.Send(getFolderCommand);

    public async Task<GetAllFoldersResponse> GetAllFolders(GetAllFoldersCommand getAllCommand)
        => await this.Mediator.Send(getAllCommand);

    public async Task<UpdateFolderResponse> UpdateFolder(UpdateFolderCommand updateFolderCommand)
        => await this.Mediator.Send(updateFolderCommand);

    public async Task<DeleteFolderResponse> DeleteFolder(DeleteFolderCommand deleteFolderCommand)
        => await this.Mediator.Send(deleteFolderCommand);
}
