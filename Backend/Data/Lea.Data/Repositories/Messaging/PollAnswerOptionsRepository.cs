using Lea.Data.Entities.Messaging;
using Lea.Data.Repositories.Interfaces.Messaging;

namespace Lea.Data.Repositories.Messaging;

public class PollAnswerOptionsRepository : BaseRepository<PollAnswerOption>, IPollAnswerOptionsRepository
{
    public PollAnswerOptionsRepository(LeaDbContext context) : base(context)
    {
    }
}
