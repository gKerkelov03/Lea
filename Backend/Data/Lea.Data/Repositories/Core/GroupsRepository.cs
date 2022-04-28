using Lea.Data.Entities.Core;
using Lea.Data.Repositories.Interfaces.Core;

namespace Lea.Data.Repositories.Core;

public class GroupsRepository : BaseRepository<Group>, IGroupsRepository
{
    public GroupsRepository(LeaDbContext context) : base(context)
    {
    }
}
