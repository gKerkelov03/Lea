using Lea.Services.Data.Interfaces.Core;
using Lea.Web.Commands.Core.Students;
using Lea.Web.Responses.Core.Students;
using MediatR;

namespace Lea.Web.Handlers.Core.Students;

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