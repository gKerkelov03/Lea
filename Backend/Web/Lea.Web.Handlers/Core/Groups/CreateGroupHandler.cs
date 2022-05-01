using Lea.Web.Commands.Core.Courses;
using Lea.Web.Commands.Core.Groups;
using Lea.Web.Responses.Core.Courses;
using Lea.Web.Responses.Core.Groups;
using MediatR;

namespace Lea.Web.Handlers.Core.Groups;

public class CreateGroupHandler : IRequestHandler<CreateGroupCommand, CreateGroupResponse>
{
    public Task<CreateGroupResponse> Handle(CreateGroupCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}