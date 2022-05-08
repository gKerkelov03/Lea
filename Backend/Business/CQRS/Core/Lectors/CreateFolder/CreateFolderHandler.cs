using Business.Interfaces.Data.Examination;
using MediatR;

namespace CQRS.Core.Lectors.CreateFolder;

public class CreateFolderHandler : IRequestHandler<CreateFolderCommand, CreateFolderResponse>
{
    private readonly IFoldersService foldersService;

    public CreateFolderHandler(IFoldersService foldersService)
        => this.foldersService = foldersService;

    public Task<CreateFolderResponse> Handle(CreateFolderCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}