using AutoMapper;

namespace Services.Data.Messaging;

public class ChannelsService : BaseDataService<Channel, ChannelServiceModel, ChannelsRepository>, IChannelsService
{
    public ChannelsService(ChannelsRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
