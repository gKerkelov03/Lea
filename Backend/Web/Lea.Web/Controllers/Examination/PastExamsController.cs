using Lea.Web.Commands.Examination.PastExams;
using Lea.Web.Responses.Examination.PastExams;
using Microsoft.AspNetCore.Mvc;

namespace Lea.Web.Controllers.Examination;

public class PastExamsController : ApiController
{
    
    
    public async Task<ActionResult<GetPastExamResponse>> GetPastExam(GetPastExamCommand getPastExamCommand)
        => await this.Mediator.Send(getPastExamCommand);           
}
