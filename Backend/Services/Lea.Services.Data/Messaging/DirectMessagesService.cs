using AutoMapper;
using Lea.Data.Entities.Channels;
using Lea.Data.Entities.Messaging;
using Lea.Data.Repositories.Messaging;
using Lea.Services.Data.Interfaces.Channels;
using Lea.Services.Data.Interfaces.Messaging;
using Lea.Services.Data.Models.Channels;
using Lea.Services.Data.Models.Messaging;

namespace Lea.Services.Data.Messaging;

public class DirectMessagesService : BaseDataService<DirectMessage, DirectMessageServiceModel, DirectMessagesRepository>, IDirectMessagesService
{
    public DirectMessagesService(DirectMessagesRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
