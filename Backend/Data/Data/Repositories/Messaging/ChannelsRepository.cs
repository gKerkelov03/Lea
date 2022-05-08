using Data.Entities.Messaging;
using Data.Interfaces.Messaging;

namespace Data.Repositories.Messaging;

public class ChannelsRepository : BaseRepository<Channel>, IChannelsRepository
{
    public ChannelsRepository(LeaDbContext context) : base(context)
    {
    }
}
