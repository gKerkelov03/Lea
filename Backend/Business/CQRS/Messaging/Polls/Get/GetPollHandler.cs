using Business.Interfaces.Data.Messaging;
using MediatR;

namespace CQRS.Messaging.Polls.Get;

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