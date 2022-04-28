using Lea.Data.Entities.Channels;
using Lea.Data.Repositories.Interfaces.Channels;

namespace Lea.Data.Repositories.Channels;

public class ChannelsRepository : BaseRepository<Channel>, IChannelsRepository
{
    public ChannelsRepository(LeaDbContext context) : base(context)
    {
    }
}
