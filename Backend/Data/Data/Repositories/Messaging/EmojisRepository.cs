using Data.Entities.Messaging;
using Data.Interfaces.Messaging;

namespace Data.Repositories.Messaging;

public class EmojisRepository : BaseRepository<Emoji>, IEmojisRepository
{
    public EmojisRepository(LeaDbContext context) : base(context)
    {

    }
}
