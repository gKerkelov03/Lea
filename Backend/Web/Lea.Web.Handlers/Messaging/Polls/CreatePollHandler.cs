using Lea.Services.Interfaces.Data.Messaging;
using Lea.Web.Commands.Messaging.Polls;
using Lea.Web.Responses.Messaging.Polls;
using MediatR;

namespace Lea.Web.Handlers.Messaging.Polls;

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