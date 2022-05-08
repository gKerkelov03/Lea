using Business.Interfaces.Data.Examination;
using MediatR;

namespace CQRS.Examination.Folders.Update;

public class UpdateFolderHandler : IRequestHandler<UpdateFolderCommand, UpdateFolderResponse>
{
    private readonly IFoldersService foldersService;

    public UpdateFolderHandler(IFoldersService foldersService)
        => this.foldersService = foldersService;

    public Task<UpdateFolderResponse> Handle(UpdateFolderCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}