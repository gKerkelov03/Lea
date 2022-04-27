using Lea.Data.Common;

namespace Lea.Data.Entities;

public class Class : LeaEntity
{
    public string Name { get; set; }

    public virtual ICollection<Teacher> Teachers { get; set; }

    public virtual ICollection<Student> Students { get; set; }

    public virtual ICollection<Test> UpcomingTests { get; set; }

    public virtual School School { get; set; }
}
