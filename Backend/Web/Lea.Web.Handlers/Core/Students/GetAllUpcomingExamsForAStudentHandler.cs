using Lea.Services.Interfaces.Data.Core;
using Lea.Web.Commands.Core.Students;
using Lea.Web.Responses.Core.Students;
using MediatR;

namespace Lea.Web.Handlers.Core.Students;
public class GetAllUpcomingExamsForAStudentHandler : IRequestHandler<GetAllUpcomingExamsForAStudentCommand, GetAllUpcomingExamsForAStudentResponse>
{
    private readonly IStudentsService studentsService;

    public GetAllUpcomingExamsForAStudentHandler(IStudentsService groupsService)
        => this.studentsService = groupsService;

    public Task<GetAllUpcomingExamsForAStudentResponse> Handle(GetAllUpcomingExamsForAStudentCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
