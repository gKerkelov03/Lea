using Lea.Web.Commands.Examination.UpcomingExams;
using Lea.Web.Responses.Examination.UpcomingExams;
using Microsoft.AspNetCore.Mvc;

namespace Lea.Web.Controllers.Examination;

public class UpcomingExamsController : ApiController
{
    public async Task<ActionResult<CreateUpcomingExamResponse>> CreateUpcomingExam(CreateUpcomingExamCommand createUpcomingExamCommand)
    => await this.Mediator.Send(createUpcomingExamCommand);

    public async Task<ActionResult<GetUpcomingExamResponse>> GetUpcomingExam(GetUpcomingExamCommand getUpcomingExamCommand)
   => await this.Mediator.Send(getUpcomingExamCommand);
    
    //update start time and end time
    public async Task<ActionResult<UpdateUpcomingExamResponse>> UpdateUpcomingExam(UpdateUpcomingExamCommand updateUpcomingExamCommand)
    => await this.Mediator.Send(updateUpcomingExamCommand);

    public async Task<ActionResult<DeleteUpcomingExamResponse>> DeleteUpcomingExam(DeleteUpcomingExamCommand deleteUpcomingExamCommand)
    => await this.Mediator.Send(deleteUpcomingExamCommand);
}
