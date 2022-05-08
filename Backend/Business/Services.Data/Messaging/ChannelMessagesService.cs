using AutoMapper;

namespace Services.Data.Messaging;

public class ChannelMessagesService : BaseDataService<ChannelMessage, ChannelMessageServiceModel, ChannelMessagesRepository>, IChannelMessagesService
{
    public ChannelMessagesService(ChannelMessagesRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
