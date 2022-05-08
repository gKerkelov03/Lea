using Business.Interfaces.Data.Core;
using MediatR;

namespace CQRS.Core.Students.GetAllGroups;
public class GetAllGroupsForAStudentHandler : IRequestHandler<GetAllGroupsForAStudentCommand, GetAllGroupsForAStudentResponse>
{
    private readonly IStudentsService studentsService;

    public GetAllGroupsForAStudentHandler(IStudentsService groupsService)
        => studentsService = groupsService;

    public Task<GetAllGroupsForAStudentResponse> Handle(GetAllGroupsForAStudentCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
