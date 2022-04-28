using AutoMapper;
using Lea.Data.Entities.Channels;
using Lea.Data.Repositories.Channels;
using Lea.Services.Data.Models.Channels;

namespace Lea.Services.Data.Interfaces.Channels;

public class ChannelMessagesService : BaseDataService<ChannelMessage, ChannelMessageServiceModel, ChannelMessagesRepository>, IChannelMessagesService
{
    public ChannelMessagesService(ChannelMessagesRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
