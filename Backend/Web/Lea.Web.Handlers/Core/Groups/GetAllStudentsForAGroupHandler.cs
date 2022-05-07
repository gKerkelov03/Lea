using Lea.Services.Interfaces.Data.Core;
using Lea.Web.Commands.Core.Groups;
using Lea.Web.Responses.Core.Groups;
using MediatR;

namespace Lea.Web.Handlers.Core.Groups;

public class GetAllStudentsForAGroupHandler : IRequestHandler<GetAllStudentsForAGroupCommand, GetAllStudentsForAGroupResponse>
{
    private readonly IStudentsService groupsService;

    public GetAllStudentsForAGroupHandler(IStudentsService groupsService)
        => this.groupsService = groupsService;

    public Task<GetAllStudentsForAGroupResponse> Handle(GetAllStudentsForAGroupCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}