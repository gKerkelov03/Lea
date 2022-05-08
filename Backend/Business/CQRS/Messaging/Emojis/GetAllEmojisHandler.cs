using Business.Interfaces.Data.Messaging;
using MediatR;

namespace CQRS.Messaging.Emojis;

public class GetAllEmojisHandler : IRequestHandler<GetAllEmojisCommand, GetAllEmojisResponse>
{
    private readonly IEmojisService emojisService;

    public GetAllEmojisHandler(IEmojisService emojisService)
        => this.emojisService = emojisService;

    public Task<GetAllEmojisResponse> Handle(GetAllEmojisCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}