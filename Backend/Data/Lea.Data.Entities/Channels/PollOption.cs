using Lea.Data.Common;
using Lea.Data.Entities.Core;

namespace Lea.Data.Entities.Channels;

public class PollOption : LeaEntity
{
    public string Text { get; set; }

    public virtual ICollection<Student> StudentsVoted { get; set; }
}
