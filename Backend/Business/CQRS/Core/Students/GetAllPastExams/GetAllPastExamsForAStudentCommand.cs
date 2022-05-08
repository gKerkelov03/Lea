using MediatR;

namespace CQRS.Core.Students.GetAllPastExams;

public class GetAllPastExamsForAStudentCommand : IRequest<GetAllPastExamsForAStudentResponse>
{
}