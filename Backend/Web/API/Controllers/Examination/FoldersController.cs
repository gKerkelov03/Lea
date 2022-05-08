using CQRS.Examination.Folders.CreateExamQuestion;
using CQRS.Examination.Folders.Delete;
using CQRS.Examination.Folders.Get;
using CQRS.Examination.Folders.Update;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Examination;

public class FoldersController : ApiController
{
    public async Task<ActionResult<CreateExamQuestionResponse>> CreateExamQuestion(CreateExamQuestionCommand createExamQuestionCommand)
        => await Mediator.Send(createExamQuestionCommand);

    public async Task<ActionResult<GetFolderResponse>> GetFolder(GetFolderCommand getFolderCommand)
        => await Mediator.Send(getFolderCommand);

    public async Task<ActionResult<UpdateFolderResponse>> UpdateFolder(UpdateFolderCommand updateFolderCommand)
        => await Mediator.Send(updateFolderCommand);

    public async Task<ActionResult<DeleteFolderResponse>> DeleteFolder(DeleteFolderCommand deleteFolderCommand)
        => await Mediator.Send(deleteFolderCommand);
}
