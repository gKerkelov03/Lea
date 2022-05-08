using Data.Common;
using Data.Entities.Identity;

namespace Data.Entities.Messaging;
public class DirectMessage : LeaEntity
{
    //TODO: Add message content property but it should support sending files too (pictures, pdfs, rars)

    public virtual LeaUser Sender { get; set; }

    public virtual LeaUser Receiver { get; set; }

    public virtual ICollection<Emoji> Emojis { get; set; }
}
