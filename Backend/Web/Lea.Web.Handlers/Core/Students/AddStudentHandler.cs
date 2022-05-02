using Lea.Services.Data.Interfaces.Core;
using Lea.Web.Commands.Core.Students;
using Lea.Web.Responses.Core.Students;
using MediatR;

namespace Lea.Web.Handlers.Core.Students;

public class AddStudentHandler : IRequestHandler<AddStudentCommand, AddStudentResponse>
{
    private readonly IStudentsService groupsService;

    public AddStudentHandler(IStudentsService groupsService)
        => this.groupsService = groupsService;

    public Task<AddStudentResponse> Handle(AddStudentCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}