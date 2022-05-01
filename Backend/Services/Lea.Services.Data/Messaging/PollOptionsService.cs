using AutoMapper;
using Lea.Data.Entities.Messaging;
using Lea.Data.Repositories.Messaging;
using Lea.Services.Data.Interfaces.Messaging;
using Lea.Services.Data.Models.Messaging;

namespace Lea.Services.Data.Messaging;

public class PollOptionsService : BaseDataService<PollOption, PollOptionServiceModel, PollOptionsRepository>, IPollOptionsService
{
    public PollOptionsService(PollOptionsRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
