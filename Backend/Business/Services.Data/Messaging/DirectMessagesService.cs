using AutoMapper;

namespace Services.Data.Messaging;

public class DirectMessagesService : BaseDataService<DirectMessage, DirectMessageServiceModel, DirectMessagesRepository>, IDirectMessagesService
{
    public DirectMessagesService(DirectMessagesRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
