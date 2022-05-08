using MediatR;

namespace CQRS.Examination.UpcomingExams.Get;

public class GetUpcomingExamCommand : IRequest<GetUpcomingExamResponse>
{
}