using AutoMapper;
using Lea.Data.Entities.Channels;
using Lea.Data.Repositories.Channels;
using Lea.Services.Data.Interfaces.Channels;
using Lea.Services.Data.Models.Channels;

namespace Lea.Services.Data.Channels;

public class ChannelsService : BaseDataService<Channel, ChannelServiceModel, ChannelsRepository>, IChannelsService
{
    public ChannelsService(ChannelsRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
