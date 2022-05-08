using AutoMapper;

namespace Services.Data.Core;

public class GroupsService : BaseDataService<Group, GroupServiceModel, GroupsRepository>, IGroupsService
{
    public GroupsService(GroupsRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
