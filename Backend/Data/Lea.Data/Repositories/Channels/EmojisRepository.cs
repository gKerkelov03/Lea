using Lea.Data.Entities.Channels;
using Lea.Data.Repositories.Interfaces.Channels;

namespace Lea.Data.Repositories.Channels;

public class EmojisRepository : BaseRepository<Emoji>, IEmojisRepository
{
    public EmojisRepository(LeaDbContext context) : base(context)
    {

    }
}
