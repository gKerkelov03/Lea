using AutoMapper;
using Lea.Data.Entities.Channels;
using Lea.Data.Repositories.Channels;
using Lea.Services.Data.Interfaces.Channels;
using Lea.Services.Data.Models.Channels;

namespace Lea.Services.Data.Channels;

public class PollsService : BaseDataService<Poll, PollServiceModel, PollsRepository>, IPollsService
{
    public PollsService(PollsRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
