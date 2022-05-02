using Lea.Services.Data.Interfaces.Messaging;
using Lea.Web.Commands.Messaging.ChannelMessages;
using Lea.Web.Responses.Messaging.ChannelMessages;
using MediatR;

namespace Lea.Web.Handlers.Messaging.ChannelMessages;

public class GetAllChannelMessagesHandler : IRequestHandler<GetAllChannelMessagesCommand, GetAllChannelMessagesResponse>
{
    private readonly IChannelMessagesService channelMessagesService;

    public GetAllChannelMessagesHandler(IChannelMessagesService channelMessagesService) 
        => this.channelMessagesService = channelMessagesService;

    public Task<GetAllChannelMessagesResponse> Handle(GetAllChannelMessagesCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}