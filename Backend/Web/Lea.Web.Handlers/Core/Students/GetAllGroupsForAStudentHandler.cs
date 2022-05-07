using Lea.Services.Interfaces.Data.Core;
using Lea.Web.Commands.Core.Students;
using Lea.Web.Responses.Core.Students;
using MediatR;

namespace Lea.Web.Handlers.Core.Students;
public class GetAllGroupsForAStudentHandler : IRequestHandler<GetAllGroupsForAStudentCommand, GetAllGroupsForAStudentResponse>
{
    private readonly IStudentsService studentsService;

    public GetAllGroupsForAStudentHandler(IStudentsService groupsService)
        => this.studentsService = groupsService;

    public Task<GetAllGroupsForAStudentResponse> Handle(GetAllGroupsForAStudentCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
