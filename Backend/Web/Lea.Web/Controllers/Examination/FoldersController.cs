using Lea.Web.Commands.Examination.Folders;
using Lea.Web.Responses.Examination.Folders;
using Microsoft.AspNetCore.Mvc;

namespace Lea.Web.Controllers.Examination;

public class FoldersController : ApiController
{
    public async Task<ActionResult<CreateExamQuestionResponse>> CreateExamQuestion(CreateExamQuestionCommand createExamQuestionCommand)
        => await this.Mediator.Send(createExamQuestionCommand);

    public async Task<ActionResult<GetFolderResponse>> GetFolder(GetFolderCommand getFolderCommand)
        => await this.Mediator.Send(getFolderCommand);
     
    public async Task<ActionResult<UpdateFolderResponse>> UpdateFolder(UpdateFolderCommand updateFolderCommand)
        => await this.Mediator.Send(updateFolderCommand);

    public async Task<ActionResult<DeleteFolderResponse>> DeleteFolder(DeleteFolderCommand deleteFolderCommand)
        => await this.Mediator.Send(deleteFolderCommand);
}
