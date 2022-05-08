using MediatR;

namespace CQRS.Core.Groups.Delete;

public class DeleteGroupCommand : IRequest<DeleteGroupResponse>
{
}