using Data.Entities.Messaging;
using Services.Data.Models.Messaging;

namespace Business.Interfaces.Data.Messaging;

public interface IDirectMessagesService : IBaseDataService<DirectMessage, DirectMessageServiceModel>
{
}