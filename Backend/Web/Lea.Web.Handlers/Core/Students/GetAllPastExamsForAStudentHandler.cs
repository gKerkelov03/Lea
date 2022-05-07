using Lea.Services.Interfaces.Data.Core;
using Lea.Web.Commands.Core.Students;
using Lea.Web.Responses.Core.Students;
using MediatR;

namespace Lea.Web.Handlers.Core.Students;
public class GetAllPastExamsForAStudentHandler : IRequestHandler<GetAllPastExamsForAStudentCommand, GetAllPastExamsForAStudentResponse>
{
    private readonly IStudentsService studentsService;

    public GetAllPastExamsForAStudentHandler(IStudentsService groupsService)
        => this.studentsService = groupsService;

    public Task<GetAllPastExamsForAStudentResponse> Handle(GetAllPastExamsForAStudentCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
