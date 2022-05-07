using Lea.Data.Entities.Messaging;
using Lea.Data.Interfaces.Messaging;

namespace Lea.Data.Repositories.Messaging;

public class PollsRepository : BaseRepository<Poll>, IPollsRepository
{
    public PollsRepository(LeaDbContext context) : base(context)
    {
    }
}
