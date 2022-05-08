using Business.Interfaces.Data.Core;
using MediatR;

namespace CQRS.Core.Students.GetAllPastExams;
public class GetAllPastExamsForAStudentHandler : IRequestHandler<GetAllPastExamsForAStudentCommand, GetAllPastExamsForAStudentResponse>
{
    private readonly IStudentsService studentsService;

    public GetAllPastExamsForAStudentHandler(IStudentsService groupsService)
        => studentsService = groupsService;

    public Task<GetAllPastExamsForAStudentResponse> Handle(GetAllPastExamsForAStudentCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
