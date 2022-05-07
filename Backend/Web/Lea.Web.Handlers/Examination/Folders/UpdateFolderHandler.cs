using Lea.Services.Interfaces.Data.Examination;
using Lea.Web.Commands.Examination.Folders;
using Lea.Web.Responses.Examination.Folders;
using MediatR;

namespace Lea.Web.Handlers.Examination.Folders;

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