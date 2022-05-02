using Lea.Services.Data.Interfaces.Examination;
using Lea.Web.Commands.Examination.PastExams;
using Lea.Web.Responses.Examination.PastExams;
using MediatR;

namespace Lea.Web.Handlers.Examination.PastExams;

public class DeletePastExamHandler : IRequestHandler<DeletePastExamCommand, DeletePastExamResponse>
{
    private readonly IPastExamsService pastExamsService;

    public DeletePastExamHandler(IPastExamsService pastExamsService)
        => this.pastExamsService = pastExamsService;

    public Task<DeletePastExamResponse> Handle(DeletePastExamCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}