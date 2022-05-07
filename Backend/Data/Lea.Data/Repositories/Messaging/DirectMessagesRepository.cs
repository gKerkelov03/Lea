using Lea.Data.Entities.Messaging;
using Lea.Data.Interfaces.Messaging;

namespace Lea.Data.Repositories.Messaging;

public class DirectMessagesRepository : BaseRepository<DirectMessage>, IDirectMessagesRepository
{
    public DirectMessagesRepository(LeaDbContext context) : base(context)
    {
    }
}
