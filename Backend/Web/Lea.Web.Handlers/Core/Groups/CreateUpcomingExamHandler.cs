using Lea.Services.Data.Interfaces.Examination;
using Lea.Web.Commands.Examination.UpcomingExams;
using Lea.Web.Responses.Examination.UpcomingExams;
using MediatR;

namespace Lea.Web.Handlers.Examination.UpcomingExams;

public class CreateUpcomingExamHandler : IRequestHandler<CreateUpcomingExamCommand, CreateUpcomingExamResponse>
{
    private readonly IUpcomingExamsService upcomingExamsService;

    public CreateUpcomingExamHandler(IUpcomingExamsService upcomingExamsService)
    {
        this.upcomingExamsService = upcomingExamsService;
    }

    public Task<CreateUpcomingExamResponse> Handle(CreateUpcomingExamCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}