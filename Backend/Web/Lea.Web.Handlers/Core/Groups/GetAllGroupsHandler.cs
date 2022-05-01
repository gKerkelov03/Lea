using Lea.Web.Commands.Core.Courses;
using Lea.Web.Commands.Core.Groups;
using Lea.Web.Responses.Core.Courses;
using Lea.Web.Responses.Core.Groups;
using MediatR;

namespace Lea.Web.Handlers.Core.Groups;

public class GetAllGroupsHandler : IRequestHandler<GetAllGroupsCommand, GetAllGroupsResponse>
{
    public Task<GetAllGroupsResponse> Handle(GetAllGroupsCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}