using Lea.Services.Interfaces.Data.Messaging;
using Lea.Web.Commands.Messaging.DirectMessages;
using Lea.Web.Responses.Messaging.DirectMessages;
using MediatR;

namespace Lea.Web.Handlers.Messaging.DirectMessages;

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