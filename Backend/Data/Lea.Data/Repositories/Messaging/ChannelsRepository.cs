using Lea.Data.Entities.Messaging;
using Lea.Data.Repositories.Interfaces.Messaging;

namespace Lea.Data.Repositories.Messaging;

public class ChannelsRepository : BaseRepository<Channel>, IChannelsRepository
{
    public ChannelsRepository(LeaDbContext context) : base(context)
    {
    }
}
