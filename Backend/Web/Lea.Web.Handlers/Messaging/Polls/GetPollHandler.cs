using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Messaging.Polls;
using Lea.Web.Responses.Messaging.Polls;
using MediatR;

namespace Lea.Web.Handlers.Messaging.Polls;

public class GetPollHandler : IRequestHandler<GetPollCommand, GetPollReponse>
{
    private readonly IPollsService pollsService;

    public GetPollHandler(IPollsService pollsService)
        => this.pollsService = pollsService;

    public Task<GetPollReponse> Handle(GetPollCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}