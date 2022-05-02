using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Core.Students;
using Lea.Web.Responses.Core.Students;
using MediatR;

namespace Lea.Web.Handlers.Messaging.Polls;

public class GetAllPollsHandler : IRequestHandler<GetStudentCommand, GetStudentResponse>
{
    private readonly IPollsService pollsService;

    public GetAllPollsHandler(IPollsService pollsService)
        => this.pollsService = pollsService;

    public Task<GetStudentResponse> Handle(GetStudentCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}