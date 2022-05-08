using Data.Common;
using Data.Entities.Examination;
using Data.Entities.Identity;

namespace Data.Entities.Core;

public class Student : LeaEntity
{
    public string Name { get; set; }

    public Guid UserId { get; set; }

    public virtual LeaUser User { get; set; }

    public virtual ICollection<Group> Groups { get; set; }















    public virtual ICollection<PastExam> PastTests { get; set; }

}
