using Business.Interfaces.Data.Examination;
using MediatR;

namespace CQRS.Core.Groups.GetAllPastExams;

public class GetAllPastExamsForAGroupHandler : IRequestHandler<GetAllPastExamsForAGroupCommand, GetAllPastExamsForAGroupResponse>
{
    private readonly IPastExamsService pastExamsService;

    public GetAllPastExamsForAGroupHandler(IPastExamsService pastExamsService)
        => this.pastExamsService = pastExamsService;

    public Task<GetAllPastExamsForAGroupResponse> Handle(GetAllPastExamsForAGroupCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}