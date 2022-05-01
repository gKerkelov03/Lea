using Lea.Data.Entities.Messaging;
using Lea.Services.Data.Interfaces;
using Lea.Services.Data.Models.Messaging;

namespace Lea.Services.Data.Interfaces.Messaging;

public interface IDirectMessagesService : IBaseDataService<DirectMessage, DirectMessageServiceModel>
{
}