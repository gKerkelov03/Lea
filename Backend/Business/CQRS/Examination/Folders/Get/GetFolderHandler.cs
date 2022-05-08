using Business.Interfaces.Data.Examination;
using MediatR;

namespace CQRS.Examination.Folders.Get;

public class GetFolderHandler : IRequestHandler<GetFolderCommand, GetFolderResponse>
{
    private readonly IFoldersService foldersService;

    public GetFolderHandler(IFoldersService foldersService)
        => this.foldersService = foldersService;

    public Task<GetFolderResponse> Handle(GetFolderCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}