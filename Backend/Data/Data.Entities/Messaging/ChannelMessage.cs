using Data.Common;
using Data.Entities.Identity;

namespace Data.Entities.Messaging;

public class ChannelMessage : LeaEntity
{

    //TODO: Add message content property but it should support sending files too (pictures, pdfs, rars)

    public LeaUser Sender { get; set; }

    public virtual Channel Channel { get; set; }

    public virtual ICollection<Emoji> Emojis { get; set; }
}