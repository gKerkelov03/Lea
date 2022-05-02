using Lea.Services.Data.Interfaces.Examination;
using Lea.Web.Commands.Examination.Folders;
using Lea.Web.Responses.Examination.Folders;
using MediatR;

namespace Lea.Web.Handlers.Examination.Folders;

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