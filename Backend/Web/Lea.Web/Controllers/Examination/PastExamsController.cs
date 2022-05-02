using Lea.Web.Commands.Examination.PastExams;
using Lea.Web.Responses.Examination.PastExams;

namespace Lea.Web.Controllers.Examination;

public class PastExamsController : ApiController
{
    public async Task<CreatePastExamResponse> CreatePastExam(CreatePastExamCommand createPastExamCommand)
        => await this.Mediator.Send(createPastExamCommand);

    public async Task<GetPastExamResponse> GetPastExam(GetPastExamCommand getPastExamCommand)
        => await this.Mediator.Send(getPastExamCommand);

    public async Task<GetAllPastExamsResponse> GetAllPastExams(GetAllPastExamsCommand getAllPastExamsCommand)
        => await this.Mediator.Send(getAllPastExamsCommand);

    public async Task<UpdatePastExamResponse> UpdatePastExam(UpdatePastExamCommand updatePastExamCommand)
        => await this.Mediator.Send(updatePastExamCommand);

    public async Task<DeletePastExamResponse> DeletePastExam(DeletePastExamCommand deletePastExamCommand)
        => await this.Mediator.Send(deletePastExamCommand);
}
