using Business.Interfaces.Data.Examination;
using MediatR;

namespace CQRS.Core.Groups.CreatePastExam;

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