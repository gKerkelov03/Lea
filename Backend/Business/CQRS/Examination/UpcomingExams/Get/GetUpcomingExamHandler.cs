using Business.Interfaces.Data.Examination;
using MediatR;

namespace CQRS.Examination.UpcomingExams.Get;

public class GetUpcomingExamHandler : IRequestHandler<GetUpcomingExamCommand, GetUpcomingExamResponse>
{
    private readonly IUpcomingExamsService upcomingExamsService;

    public GetUpcomingExamHandler(IUpcomingExamsService upcomingExamsService)
    {
        this.upcomingExamsService = upcomingExamsService;
    }

    public Task<GetUpcomingExamResponse> Handle(GetUpcomingExamCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}