using AutoMapper;
using Lea.Data.Entities.Channels;
using Lea.Data.Repositories.Channels;
using Lea.Services.Data.Models.Channels;

namespace Lea.Services.Data.Interfaces.Channels;

public class PollOptionsService : BaseDataService<PollOption, PollOptionServiceModel, PollOptionsRepository>, IPollOptionsService
{
    public PollOptionsService(PollOptionsRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
