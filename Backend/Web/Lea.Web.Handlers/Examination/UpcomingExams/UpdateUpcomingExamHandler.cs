using Lea.Services.Interfaces.Data.Examination;
using Lea.Web.Commands.Examination.UpcomingExams;
using Lea.Web.Responses.Examination.UpcomingExams;
using MediatR;

namespace Lea.Web.Handlers.Examination.UpcomingExams;

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