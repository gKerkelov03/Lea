using Lea.Services.Data.Interfaces.Examination;
using Lea.Web.Commands.Examination.Folders;
using Lea.Web.Responses.Examination.Folders;
using MediatR;

namespace Lea.Web.Handlers.Examination.Folders;

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