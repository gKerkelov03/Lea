using Lea.Services.Data.Interfaces.Core;
using Lea.Web.Commands.Core.Students;
using Lea.Web.Controllers.Core;
using Lea.Web.Responses.Core.Students;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
