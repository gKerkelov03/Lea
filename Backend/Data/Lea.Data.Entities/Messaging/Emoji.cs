using Lea.Data.Common;

namespace Lea.Data.Entities.Messaging;

public class Emoji : LeaEntity
{
    public string IconUrl { get; set; }

    public string Name { get; set; }

    public virtual ICollection<ChannelMessage> ChannelMessagesMarkedWithIt { get; set; }

    public virtual ICollection<ChannelMessage> DirectMessagesMarkedWithIt { get; set; }

}