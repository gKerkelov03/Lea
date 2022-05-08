using MediatR;

namespace CQRS.Core.Students.GetAllUpcomingExams;

public class GetAllUpcomingExamsForAStudentCommand : IRequest<GetAllUpcomingExamsForAStudentResponse>
{
}