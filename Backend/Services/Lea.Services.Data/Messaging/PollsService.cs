﻿using AutoMapper;
using Lea.Data.Entities.Messaging;
using Lea.Data.Repositories.Messaging;
using Lea.Services.Data.Models.Messaging;
using Lea.Services.Interfaces.Data.Messaging;

namespace Lea.Services.Data.Messaging;

public class PollsService : BaseDataService<Poll, PollServiceModel, PollsRepository>, IPollsService
{
    public PollsService(PollsRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
