using Lea.Services.Data.Interfaces.Core;
using Lea.Web.Commands.Core.Groups;
using Lea.Web.Responses.Core.Groups;
using MediatR;

namespace Lea.Web.Handlers.Core.Groups;

public class GetAllGroupsHandler : IRequestHandler<GetAllGroupsCommand, GetAllGroupsResponse>
{
    private readonly IGroupsService groupsService;

    public GetAllGroupsHandler(IGroupsService groupsService)
        => this.groupsService = groupsService;

    public Task<GetAllGroupsResponse> Handle(GetAllGroupsCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}