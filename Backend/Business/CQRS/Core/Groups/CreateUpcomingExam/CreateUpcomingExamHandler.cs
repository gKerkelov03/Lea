using Business.Interfaces.Data.Examination;
using MediatR;

namespace CQRS.Core.Groups.CreateUpcomingExam;

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