using Lea.Data.Entities.Messaging;
using Lea.Data.Interfaces.Messaging;

namespace Lea.Data.Repositories.Messaging;

public class ChannelMessagesRepository : BaseRepository<ChannelMessage>, IChannelMessagesRepository
{
    public ChannelMessagesRepository(LeaDbContext context) : base(context)
    {
    }
}
