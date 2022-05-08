using Data.Entities.Messaging;
using Data.Interfaces.Messaging;

namespace Data.Repositories.Messaging;

public class ChannelMessagesRepository : BaseRepository<ChannelMessage>, IChannelMessagesRepository
{
    public ChannelMessagesRepository(LeaDbContext context) : base(context)
    {
    }
}
