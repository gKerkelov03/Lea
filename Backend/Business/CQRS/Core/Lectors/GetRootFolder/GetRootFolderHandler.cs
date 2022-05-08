using Business.Interfaces.Data.Core;
using MediatR;

namespace CQRS.Core.Lectors.GetRootFolder;

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