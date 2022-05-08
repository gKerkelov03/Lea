using Data.Entities.Core;
using Data.Interfaces.Core;

namespace Data.Repositories.Core;

public class GroupsRepository : BaseRepository<Group>, IGroupsRepository
{
    public GroupsRepository(LeaDbContext context) : base(context)
    {
    }
}
