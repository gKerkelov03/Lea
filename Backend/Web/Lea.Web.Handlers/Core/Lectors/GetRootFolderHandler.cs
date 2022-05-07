using Lea.Services.Interfaces.Data.Core;
using Lea.Web.Commands.Core.Lectors;
using Lea.Web.Responses.Core.Lectors;
using MediatR;

namespace Lea.Web.Handlers.Core.Lectors;

public class GetRootFolderHandler : IRequestHandler<GetRootFolderCommand, GetRootFolderResponse>
{
    private readonly ILectorsService groupsService;

    public GetRootFolderHandler(ILectorsService groupsService)
        => this.groupsService = groupsService;

    public Task<GetRootFolderResponse> Handle(GetRootFolderCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}