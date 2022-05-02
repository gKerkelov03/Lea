using Lea.Services.Data.Interfaces.Core;
using Lea.Web.Commands.Core.Students;
using Lea.Web.Responses.Core.Students;
using MediatR;

namespace Lea.Web.Handlers.Core.Students;

public class GetStudentHandler : IRequestHandler<GetStudentCommand, GetStudentResponse>
{
    private readonly IStudentsService groupsService;

    public GetStudentHandler(IStudentsService groupsService)
        => this.groupsService = groupsService;

    public Task<GetStudentResponse> Handle(GetStudentCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}