using Lea.Services.Data.Interfaces.Examination;
using Lea.Web.Commands.Examination.UpcomingExams;
using Lea.Web.Responses.Examination.UpcomingExams;
using MediatR;

namespace Lea.Web.Handlers.Examination.UpcomingExams;

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