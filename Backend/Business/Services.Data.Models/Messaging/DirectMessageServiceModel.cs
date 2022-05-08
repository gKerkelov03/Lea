using Data.Entities.Messaging;
using Mappings.Conventions;

namespace Services.Data.Models.Messaging;

public class DirectMessageServiceModel : BaseServiceModel, IMapToAndFrom<DirectMessage>
{
}