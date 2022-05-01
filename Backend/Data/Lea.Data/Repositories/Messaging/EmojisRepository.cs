using Lea.Data.Entities.Messaging;
using Lea.Data.Repositories.Interfaces.Messaging;

namespace Lea.Data.Repositories.Messaging;

public class EmojisRepository : BaseRepository<Emoji>, IEmojisRepository
{
    public EmojisRepository(LeaDbContext context) : base(context)
    {

    }
}
