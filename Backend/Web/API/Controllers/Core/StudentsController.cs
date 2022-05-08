using CQRS.Core.Students.Delete;
using CQRS.Core.Students.GetAllGroups;
using CQRS.Core.Students.GetAllPastExams;
using CQRS.Core.Students.GetAllUpcomingExams;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Core;

public class StudentsController : ApiController
{
    //Students
    public async Task<ActionResult<DeleteStudentRoleResponse>> DeleteStudentRole(DeleteStudentRoleCommand deleteStudentCommand)
        => await Mediator.Send(deleteStudentCommand);


    //Groups
    public async Task<ActionResult<GetAllGroupsForAStudentResponse>> GetAllGroupsForAStudent(GetAllGroupsForAStudentCommand getAllGroupsCommand)
        => await Mediator.Send(getAllGroupsCommand);


    //UpcomingExams
    public async Task<ActionResult<GetAllUpcomingExamsForAStudentResponse>> GetAllUpcomingExams(GetAllUpcomingExamsForAStudentCommand getAllUpcomingExamsCommand)
        => await Mediator.Send(getAllUpcomingExamsCommand);


    //PastExams
    public async Task<ActionResult<GetAllPastExamsForAStudentResponse>> GetAllPastExams(GetAllPastExamsForAStudentCommand getAllPastExamsCommand)
        => await Mediator.Send(getAllPastExamsCommand);
}
