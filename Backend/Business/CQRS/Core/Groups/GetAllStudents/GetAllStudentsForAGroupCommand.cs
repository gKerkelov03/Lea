using MediatR;

namespace CQRS.Core.Groups.GetAllStudents;

public class GetAllStudentsForAGroupCommand : IRequest<GetAllStudentsForAGroupResponse>
{
}