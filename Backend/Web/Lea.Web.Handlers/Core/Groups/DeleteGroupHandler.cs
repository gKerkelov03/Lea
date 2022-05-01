using Lea.Web.Commands.Core.Courses;
using Lea.Web.Commands.Core.Groups;
using Lea.Web.Responses.Core.Courses;
using Lea.Web.Responses.Core.Groups;
using MediatR;

namespace Lea.Web.Handlers.Core.Groups;

public class DeleteGroupHandler : IRequestHandler<DeleteGroupCommand, DeleteGroupResponse>
{
    public Task<DeleteGroupResponse> Handle(DeleteGroupCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}