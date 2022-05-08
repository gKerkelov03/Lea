using Data.Common;
using Data.Entities.Core;

namespace Data.Entities.Messaging;

public class Poll : LeaEntity
{
    public string Question { get; set; }

    public virtual Group Group { get; set; }

    public virtual ICollection<PollAnswerOption> Options { get; set; }
}
