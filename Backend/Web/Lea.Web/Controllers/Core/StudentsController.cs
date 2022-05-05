using Lea.Web.Commands.Core.Students;
using Lea.Web.Commands.Examination.PastExams;
using Lea.Web.Responses.Core.Students;
using Lea.Web.Responses.Examination.PastExams;
using Microsoft.AspNetCore.Mvc;

namespace Lea.Web.Controllers.Core;

public class StudentsController : ApiController
{    
    //Students
    public async Task<ActionResult<DeleteStudentRoleResponse>> DeleteStudentRole(DeleteStudentRoleCommand deleteStudentCommand)
        => await this.Mediator.Send(deleteStudentCommand);
    
    
    //Groups
    public async Task<ActionResult<GetAllGroupsForAStudentResponse>> GetAllGroupsForAStudent(GetAllGroupsForAStudentCommand getAllGroupsCommand)
        => await this.Mediator.Send(getAllGroupsCommand);


    //UpcomingExams
    public async Task<ActionResult<GetAllUpcomingExamsForAStudentResponse>> GetAllUpcomingExams(GetAllUpcomingExamsForAStudentCommand getAllUpcomingExamsCommand)
        => await this.Mediator.Send(getAllUpcomingExamsCommand);


    //PastExams
    public async Task<ActionResult<GetAllPastExamsForAStudentResponse>> GetAllPastExams(GetAllPastExamsForAStudentCommand getAllPastExamsCommand)
        => await this.Mediator.Send(getAllPastExamsCommand);

    
}
