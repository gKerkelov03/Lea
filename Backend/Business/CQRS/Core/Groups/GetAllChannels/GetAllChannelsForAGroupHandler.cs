using Business.Interfaces.Data.Messaging;
using MediatR;

namespace CQRS.Core.Groups.GetAllChannels;

public class GetAllChannelsForAGroupHandler : IRequestHandler<GetAllChannelsForAGroupCommand, GetAllChannelsForAGroupResponse>
{
    private readonly IChannelsService channelsService;

    public GetAllChannelsForAGroupHandler(IChannelsService channelsService)
        => this.channelsService = channelsService;

    public Task<GetAllChannelsForAGroupResponse> Handle(GetAllChannelsForAGroupCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}