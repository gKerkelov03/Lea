using Lea.Web.Commands.Examination.UpcomingExams;
using Lea.Web.Responses.Examination.UpcomingExams;

namespace Lea.Web.Controllers.Examination;

public class UpcomingExamsController : ApiController
{
    public async Task<CreateUpcomingExamResponse> CreateUpcomingExam(CreateUpcomingExamCommand createUpcomingExamCommand)
    => await this.Mediator.Send(createUpcomingExamCommand);

    public async Task<GetUpcomingExamResponse> GetUpcomingExam(GetUpcomingExamCommand getUpcomingExamCommand)
   => await this.Mediator.Send(getUpcomingExamCommand);

    public async Task<GetAllUpcomingExamsResponse> GetAllUpcomingExams(GetAllUpcomingExamsCommand getAllUpcomingExamsCommand)
    => await this.Mediator.Send(getAllUpcomingExamsCommand);

    public async Task<UpdateUpcomingExamResponse> UpdateUpcomingExam(UpdateUpcomingExamCommand updateUpcomingExamCommand)
    => await this.Mediator.Send(updateUpcomingExamCommand);

    public async Task<DeleteUpcomingExamResponse> DeleteUpcomingExam(DeleteUpcomingExamCommand deleteUpcomingExamCommand)
    => await this.Mediator.Send(deleteUpcomingExamCommand);
}
