using Lea.Data.Common;

namespace Lea.Data.Entities;

public class School : LeaEntity
{
    public string Name { get; set; }

    public virtual ICollection<Teacher> Teachers { get; set; }

    public virtual ICollection<Class> Classes { get; set; }

    public virtual ICollection<User> Admins { get; set; }

    public virtual User Director { get; set; }
}
