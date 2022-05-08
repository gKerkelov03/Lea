using Business.Interfaces.Data.Messaging;
using MediatR;

namespace CQRS.Messaging.DirectMessages.GetAllEmojis;

public class GetAllEmojisForADirectMessageHandler : IRequestHandler<GetAllEmojisForADirectMessageCommand, GetAllEmojisForADirectMessageResponse>
{
    private readonly IEmojisService emojisService;

    public GetAllEmojisForADirectMessageHandler(IEmojisService emojisService)
        => this.emojisService = emojisService;

    public Task<GetAllEmojisForADirectMessageResponse> Handle(GetAllEmojisForADirectMessageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}