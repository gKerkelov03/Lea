using Lea.Services.Data.Interfaces.Examination;
using Lea.Web.Commands.Examination.PastExams;
using Lea.Web.Responses.Examination.PastExams;
using MediatR;

namespace Lea.Web.Handlers.Examination.PastExams;

public class UpdatePastExamHandler : IRequestHandler<UpdatePastExamCommand, UpdatePastExamResponse>
{
    private readonly IPastExamsService pastExamsService;

    public UpdatePastExamHandler(IPastExamsService pastExamsService)
        => this.pastExamsService = pastExamsService;

    public Task<UpdatePastExamResponse> Handle(UpdatePastExamCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}