using Lea.Data.Common;

namespace Lea.Data.Entities;

public class Student : LeaEntity
{
    public string Name { get; set; }

    public virtual ICollection<Test> TestsPassed { get; set; }

    public virtual ICollection<Class> Classes { get; set; }

    public virtual School School { get; set; }

    public virtual User User { get; set; }
}
