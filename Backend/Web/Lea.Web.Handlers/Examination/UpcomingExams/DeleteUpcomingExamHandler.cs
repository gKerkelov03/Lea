using Lea.Services.Interfaces.Data.Examination;
using Lea.Web.Commands.Examination.UpcomingExams;
using Lea.Web.Responses.Examination.UpcomingExams;
using MediatR;

namespace Lea.Web.Handlers.Examination.UpcomingExams;

public class DeleteUpcomingExamHandler : IRequestHandler<DeleteUpcomingExamCommand, DeleteUpcomingExamResponse>
{
    private readonly IUpcomingExamsService upcomingExamsService;

    public DeleteUpcomingExamHandler(IUpcomingExamsService upcomingExamsService)
    {
        this.upcomingExamsService = upcomingExamsService;
    }

    public Task<DeleteUpcomingExamResponse> Handle(DeleteUpcomingExamCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}