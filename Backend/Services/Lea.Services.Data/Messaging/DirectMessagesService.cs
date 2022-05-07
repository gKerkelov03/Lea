using AutoMapper;
using Lea.Data.Entities.Messaging;
using Lea.Data.Repositories.Messaging;
using Lea.Services.Data.Models.Messaging;
using Lea.Services.Interfaces.Data.Messaging;

namespace Lea.Services.Data.Messaging;

public class DirectMessagesService : BaseDataService<DirectMessage, DirectMessageServiceModel, DirectMessagesRepository>, IDirectMessagesService
{
    public DirectMessagesService(DirectMessagesRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
