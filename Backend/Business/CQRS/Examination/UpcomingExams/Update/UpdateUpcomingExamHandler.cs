using Business.Interfaces.Data.Examination;
using MediatR;

namespace CQRS.Examination.UpcomingExams.Update;

public class UpdateUpcomingExamHandler : IRequestHandler<UpdateUpcomingExamCommand, UpdateUpcomingExamResponse>
{
    private readonly IUpcomingExamsService upcomingExamsService;

    public UpdateUpcomingExamHandler(IUpcomingExamsService upcomingExamsService)
    {
        this.upcomingExamsService = upcomingExamsService;
    }

    public Task<UpdateUpcomingExamResponse> Handle(UpdateUpcomingExamCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}