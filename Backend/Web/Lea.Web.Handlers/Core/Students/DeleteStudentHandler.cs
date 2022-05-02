using Lea.Services.Data.Interfaces.Core;
using Lea.Web.Commands.Core.Students;
using Lea.Web.Responses.Core.Students;
using MediatR;

namespace Lea.Web.Handlers.Core.Students;

public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, DeleteStudentResponse>
{
    private readonly IStudentsService groupsService;

    public DeleteStudentHandler(IStudentsService groupsService)
        => this.groupsService = groupsService;

    public Task<DeleteStudentResponse> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}