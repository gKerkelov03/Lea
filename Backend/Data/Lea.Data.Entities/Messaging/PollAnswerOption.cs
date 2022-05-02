using Lea.Data.Common;
using Lea.Data.Entities.Core;

namespace Lea.Data.Entities.Messaging;

public class PollAnswerOption : LeaEntity
{
    public string Text { get; set; }

    public virtual ICollection<Student> StudentsVoted { get; set; }
}
