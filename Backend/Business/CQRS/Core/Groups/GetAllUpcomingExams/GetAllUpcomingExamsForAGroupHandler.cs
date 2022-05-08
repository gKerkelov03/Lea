using Business.Interfaces.Data.Examination;
using MediatR;

namespace CQRS.Core.Groups.GetAllUpcomingExams;

public class GetAllUpcomingExamsForAGroupHandler : IRequestHandler<GetAllUpcomingExamsForAGroupCommand, GetAllUpcomingExamsForAGroupResponse>
{
    private readonly IUpcomingExamsService upcomingExamsService;

    public GetAllUpcomingExamsForAGroupHandler(IUpcomingExamsService upcomingExamsService)
    {
        this.upcomingExamsService = upcomingExamsService;
    }

    public Task<GetAllUpcomingExamsForAGroupResponse> Handle(GetAllUpcomingExamsForAGroupCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}