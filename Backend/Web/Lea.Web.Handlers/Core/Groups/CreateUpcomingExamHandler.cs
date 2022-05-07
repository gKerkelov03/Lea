using Lea.Services.Interfaces.Data.Examination;
using Lea.Web.Commands.Core.Groups;
using Lea.Web.Responses.Core.Groups;
using MediatR;

namespace Lea.Web.Handlers.Core.Groups;

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