using Lea.Services.Interfaces.Data.Examination;
using Lea.Web.Commands.Examination.Folders;
using Lea.Web.Responses.Examination.Folders;
using MediatR;

namespace Lea.Web.Handlers.Examination.Folders;

public class DeleteFolderHandler : IRequestHandler<DeleteFolderCommand, DeleteFolderResponse>
{
    private readonly IFoldersService foldersService;

    public DeleteFolderHandler(IFoldersService foldersService)
        => this.foldersService = foldersService;

    public Task<DeleteFolderResponse> Handle(DeleteFolderCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}