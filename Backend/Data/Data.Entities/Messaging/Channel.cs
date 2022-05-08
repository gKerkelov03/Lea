using Data.Common;
using Data.Entities.Core;

namespace Data.Entities.Messaging;
public class Channel : LeaEntity
{
    public string Name { get; set; }

    public virtual Group Group { get; set; }

    public virtual ICollection<ChannelMessage> Messages { get; set; }
}
