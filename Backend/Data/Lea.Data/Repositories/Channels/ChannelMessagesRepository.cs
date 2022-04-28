using Lea.Data.Entities.Channels;
using Lea.Data.Repositories.Interfaces.Channels;

namespace Lea.Data.Repositories.Channels;

public class ChannelMessagesRepository : BaseRepository<ChannelMessage>, IChannelMessagesRepository
{
    public ChannelMessagesRepository(LeaDbContext context) : base(context)
    {
    }
}
