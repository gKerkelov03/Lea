using Business.Interfaces.Data.Messaging;
using MediatR;

namespace CQRS.Messaging.Polls.Create;

public class CreatePollHandler : IRequestHandler<CreatePollCommand, CreatePollReponse>
{
    private readonly IPollsService pollsService;

    public CreatePollHandler(IPollsService pollsService)
        => this.pollsService = pollsService;

    public Task<CreatePollReponse> Handle(CreatePollCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}