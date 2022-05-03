using Lea.Services.Data.Interfaces.Core;
using Lea.Web.Commands.Core.Students;
using Lea.Web.Responses.Core.Students;
using MediatR;

namespace Lea.Web.Handlers.Core.Students;

public class GetAllStudentsHandler : IRequestHandler<GetAllStudentsCommand, GetAllStudentsResponse>
{
    private readonly IStudentsService groupsService;

    public GetAllStudentsHandler(IStudentsService groupsService)
        => this.groupsService = groupsService;

    public Task<GetAllStudentsResponse> Handle(GetAllStudentsCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}