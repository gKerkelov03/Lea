using Lea.Services.Interfaces.Data.Examination;
using Lea.Web.Commands.Core.Groups;
using Lea.Web.Responses.Core.Groups;
using MediatR;

namespace Lea.Web.Handlers.Core.Groups;

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