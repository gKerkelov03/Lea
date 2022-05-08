using Data.Common;
using Data.Entities.Core;

namespace Data.Entities.Messaging;

public class PollAnswerOption : LeaEntity
{
    public string Text { get; set; }

    public virtual ICollection<Student> StudentsVoted { get; set; }
}
