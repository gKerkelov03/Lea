using Lea.Services.Interfaces.Data.Core;
using Lea.Web.Commands.Core.Lectors;
using Lea.Web.Responses.Core.Lectors;
using MediatR;

namespace Lea.Web.Handlers.Core.Lectors;

public class GetAllGroupsHandler : IRequestHandler<GetAllGroupsForALectorCommand, GetAllGroupsForALectorResponse>
{
    private readonly ILectorsService groupsService;

    public GetAllGroupsHandler(ILectorsService groupsService)
        => this.groupsService = groupsService;
    
    public Task<GetAllGroupsForALectorResponse> Handle(GetAllGroupsForALectorCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}