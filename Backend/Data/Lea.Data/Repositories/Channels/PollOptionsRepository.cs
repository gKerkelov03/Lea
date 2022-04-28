using Lea.Data.Entities.Channels;
using Lea.Data.Repositories.Interfaces.Channels;

namespace Lea.Data.Repositories.Channels;

public class PollOptionsRepository : BaseRepository<PollOption>, IPollOptionsRepository
{
    public PollOptionsRepository(LeaDbContext context) : base(context)
    {
    }
}
