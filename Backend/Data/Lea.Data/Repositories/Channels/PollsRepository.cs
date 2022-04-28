using Lea.Data.Entities.Channels;
using Lea.Data.Repositories.Interfaces.Channels;

namespace Lea.Data.Repositories.Channels;

public class PollsRepository : BaseRepository<Poll>, IPollsRepository
{
    public PollsRepository(LeaDbContext context) : base(context)
    {
    }
}
