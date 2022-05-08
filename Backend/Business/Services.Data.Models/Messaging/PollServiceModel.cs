using Data.Entities.Messaging;
using Mappings.Conventions;

namespace Services.Data.Models.Messaging;

public class PollServiceModel : BaseServiceModel, IMapToAndFrom<Poll>
{
}