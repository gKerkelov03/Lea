using Business.Interfaces.Data.Core;
using MediatR;

namespace CQRS.Core.Students.GetAllUpcomingExams;
public class GetAllUpcomingExamsForAStudentHandler : IRequestHandler<GetAllUpcomingExamsForAStudentCommand, GetAllUpcomingExamsForAStudentResponse>
{
    private readonly IStudentsService studentsService;

    public GetAllUpcomingExamsForAStudentHandler(IStudentsService groupsService)
        => studentsService = groupsService;

    public Task<GetAllUpcomingExamsForAStudentResponse> Handle(GetAllUpcomingExamsForAStudentCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
