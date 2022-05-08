using Data.Entities.Messaging;
using Data.Interfaces.Messaging;

namespace Data.Repositories.Messaging;

public class DirectMessagesRepository : BaseRepository<DirectMessage>, IDirectMessagesRepository
{
    public DirectMessagesRepository(LeaDbContext context) : base(context)
    {
    }
}
