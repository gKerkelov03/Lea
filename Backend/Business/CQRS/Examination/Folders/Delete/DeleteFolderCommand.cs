using MediatR;

namespace CQRS.Examination.Folders.Delete;

public class DeleteFolderCommand : IRequest<DeleteFolderResponse>
{
}