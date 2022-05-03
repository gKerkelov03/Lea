using Lea.Web.Commands.Core.Students;
using Lea.Web.Commands.Examination.PastExams;
using Lea.Web.Responses.Core.Students;
using Lea.Web.Responses.Examination.PastExams;
using Microsoft.AspNetCore.Mvc;

namespace Lea.Web.Controllers.Core;

public class StudentsController : ApiController
{    
    public async Task<ActionResult<DeleteStudentRoleResponse>> DeleteStudentRole(DeleteStudentRoleCommand deleteStudentCommand)
        => await this.Mediator.Send(deleteStudentCommand);
            
    public async Task<ActionResult<GetAllGroupsForAStudentResponse>> GetAllGroupsForAStudent(GetAllGroupsForAStudentCommand getAllGroupsCommand)
        => await this.Mediator.Send(getAllGroupsCommand);

    public async Task<ActionResult<GetAllUpcomingExamsForAStudentResponse>> GetAllUpcomingExams(GetAllUpcomingExamsForAStudentCommand getAllUpcomingExamsCommand)
        => await this.Mediator.Send(getAllUpcomingExamsCommand);

    public async Task<ActionResult<GetAllPastExamsResponse>> GetAllPastExams(GetAllPastExamsCommand getAllPastExamsCommand)
        => await this.Mediator.Send(getAllPastExamsCommand);
}
