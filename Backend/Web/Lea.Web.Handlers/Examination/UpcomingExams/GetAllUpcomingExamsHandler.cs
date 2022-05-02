using Lea.Services.Data.Interfaces.Examination;
using Lea.Web.Commands.Examination.UpcomingExams;
using Lea.Web.Responses.Examination.UpcomingExams;
using MediatR;

namespace Lea.Web.Handlers.Examination.UpcomingExams;

public class GetAllUpcomingExamsHandler : IRequestHandler<GetAllUpcomingExamsCommand, GetAllUpcomingExamsResponse>
{
    private readonly IUpcomingExamsService upcomingExamsService;

    public GetAllUpcomingExamsHandler(IUpcomingExamsService upcomingExamsService)
    {
        this.upcomingExamsService = upcomingExamsService;
    }

    public Task<GetAllUpcomingExamsResponse> Handle(GetAllUpcomingExamsCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}