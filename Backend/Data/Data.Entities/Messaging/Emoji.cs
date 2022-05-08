using Data.Common;

namespace Data.Entities.Messaging;

public class Emoji : LeaEntity
{
    public string IconUrl { get; set; }

    public string Name { get; set; }

    public virtual ICollection<ChannelMessage> ChannelMessagesMarkedWithIt { get; set; }

    public virtual ICollection<DirectMessage> DirectMessagesMarkedWithIt { get; set; }

}