using Lea.Services.Data.Interfaces.Examination;
using Lea.Web.Commands.Examination.Folders;
using Lea.Web.Responses.Examination.Folders;
using MediatR;

namespace Lea.Web.Handlers.Examination.Folders;

public class GetAllFoldersHandler : IRequestHandler<GetAllFoldersCommand, GetAllFoldersResponse>
{
    private readonly IFoldersService foldersService;

    public GetAllFoldersHandler(IFoldersService foldersService)
        => this.foldersService = foldersService;

    public Task<GetAllFoldersResponse> Handle(GetAllFoldersCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}