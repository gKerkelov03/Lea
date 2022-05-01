using Lea.Data.Entities.Messaging;
using Lea.Data.Repositories.Interfaces.Messaging;

namespace Lea.Data.Repositories.Messaging;

public class PollOptionsRepository : BaseRepository<PollOption>, IPollOptionsRepository
{
    public PollOptionsRepository(LeaDbContext context) : base(context)
    {
    }
}
