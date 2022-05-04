using Lea.Services.Data.Interfaces.Examination;
using Lea.Web.Commands.Examination.PastExams;
using Lea.Web.Responses.Examination.PastExams;
using MediatR;

namespace Lea.Web.Handlers.Examination.PastExams;

public class CreatePastExamHandler : IRequestHandler<CreatePastExamCommand, CreatePastExamResponse>
{
    private readonly IPastExamsService pastExamsService;

    public CreatePastExamHandler(IPastExamsService pastExamsService)
        => this.pastExamsService = pastExamsService;

    public Task<CreatePastExamResponse> Handle(CreatePastExamCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}