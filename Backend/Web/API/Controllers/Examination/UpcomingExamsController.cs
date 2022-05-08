using CQRS.Examination.UpcomingExams.Delete;
using CQRS.Examination.UpcomingExams.Get;
using CQRS.Examination.UpcomingExams.Update;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Examination;

public class UpcomingExamsController : ApiController
{
    public async Task<ActionResult<GetUpcomingExamResponse>> GetUpcomingExam(GetUpcomingExamCommand getUpcomingExamCommand)
   => await Mediator.Send(getUpcomingExamCommand);

    public async Task<ActionResult<UpdateUpcomingExamResponse>> UpdateUpcomingExam(UpdateUpcomingExamCommand updateUpcomingExamCommand)
    => await Mediator.Send(updateUpcomingExamCommand);

    public async Task<ActionResult<DeleteUpcomingExamResponse>> DeleteUpcomingExam(DeleteUpcomingExamCommand deleteUpcomingExamCommand)
    => await Mediator.Send(deleteUpcomingExamCommand);
}
