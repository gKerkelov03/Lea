using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Messaging.Emojis;
using Lea.Web.Responses.Messaging.Emojis;
using MediatR;

namespace Lea.Web.Handlers.Messaging.Emojis;

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