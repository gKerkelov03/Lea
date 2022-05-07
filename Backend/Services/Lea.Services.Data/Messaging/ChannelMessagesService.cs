using AutoMapper;
using Lea.Data.Entities.Messaging;
using Lea.Data.Repositories.Messaging;
using Lea.Services.Data.Models.Messaging;
using Lea.Services.Interfaces.Data.Messaging;

namespace Lea.Services.Data.Messaging;

public class ChannelMessagesService : BaseDataService<ChannelMessage, ChannelMessageServiceModel, ChannelMessagesRepository>, IChannelMessagesService
{
    public ChannelMessagesService(ChannelMessagesRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
