using AutoMapper;

namespace Services.Data.Messaging;

public class PollsService : BaseDataService<Poll, PollServiceModel, PollsRepository>, IPollsService
{
    public PollsService(PollsRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
