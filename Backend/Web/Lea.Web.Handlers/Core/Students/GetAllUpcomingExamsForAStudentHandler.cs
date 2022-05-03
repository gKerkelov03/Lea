using Lea.Services.Data.Interfaces.Core;
using Lea.Web.Commands.Core.Students;
using Lea.Web.Responses.Core.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lea.Web.Handlers.Core.Students;
public class GetAllUpcomingExamsForAStudentHandler
{
    private readonly IStudentsService studentsService;

    public GetAllUpcomingExamsForAStudentHandler(IStudentsService groupsService)
        => this.studentsService = groupsService;

    public Task<GetAllUpcomingExamsForAStudentResponse> Handle(GetAllUpcomingExamsForAStudentCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
