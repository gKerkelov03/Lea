using AutoMapper;

namespace Services.Data.Messaging;

public class PollAnswerOptionsService : BaseDataService<PollAnswerOption, PollAnswerOptionServiceModel, PollAnswerOptionsRepository>, IPollAnswerOptionsService
{
    public PollAnswerOptionsService(PollAnswerOptionsRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
