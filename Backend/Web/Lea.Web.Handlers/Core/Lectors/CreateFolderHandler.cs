using Lea.Services.Interfaces.Data.Examination;
using Lea.Web.Commands.Core.Lectors;
using Lea.Web.Responses.Core.Lectors;
using MediatR;

namespace Lea.Web.Handlers.Core.Lectors;

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