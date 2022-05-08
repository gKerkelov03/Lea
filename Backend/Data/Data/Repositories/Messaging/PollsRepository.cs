using Data.Entities.Messaging;
using Data.Interfaces.Messaging;

namespace Data.Repositories.Messaging;

public class PollsRepository : BaseRepository<Poll>, IPollsRepository
{
    public PollsRepository(LeaDbContext context) : base(context)
    {
    }
}
