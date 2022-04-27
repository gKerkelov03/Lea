using Lea.Data.Common;

namespace Lea.Data.Entities;

public class Student : LeaEntity
{
    public string Name { get; set; }

    public virtual Course School { get; set; }

    public virtual LeaUser User { get; set; }

    public virtual ICollection<PastTest> PastTests { get; set; }

    public virtual ICollection<Group> Groups { get; set; }
}
 