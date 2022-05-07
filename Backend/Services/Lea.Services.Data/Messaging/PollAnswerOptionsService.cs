using AutoMapper;
using Lea.Data.Entities.Messaging;
using Lea.Data.Repositories.Messaging;
using Lea.Services.Data.Models.Messaging;
using Lea.Services.Interfaces.Data.Messaging;

namespace Lea.Services.Data.Messaging;

public class PollAnswerOptionsService : BaseDataService<PollAnswerOption, PollAnswerOptionServiceModel, PollAnswerOptionsRepository>, IPollAnswerOptionsService
{
    public PollAnswerOptionsService(PollAnswerOptionsRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
