using Business.Interfaces.Data.Examination;
using MediatR;

namespace CQRS.Examination.Folders.Delete;

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