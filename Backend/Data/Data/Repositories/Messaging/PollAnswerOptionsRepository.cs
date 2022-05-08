using Data.Entities.Messaging;
using Data.Interfaces.Messaging;

namespace Data.Repositories.Messaging;

public class PollAnswerOptionsRepository : BaseRepository<PollAnswerOption>, IPollAnswerOptionsRepository
{
    public PollAnswerOptionsRepository(LeaDbContext context) : base(context)
    {
    }
}
