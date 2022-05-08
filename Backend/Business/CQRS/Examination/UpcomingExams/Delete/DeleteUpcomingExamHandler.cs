using Business.Interfaces.Data.Examination;
using MediatR;

namespace CQRS.Examination.UpcomingExams.Delete;

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