using Lea.Data.Common;

namespace Lea.Data.Entities;

public class Course : LeaEntity
{
    public string Name { get; set; }

    public string Description { get; set; }

    public virtual LeaUser Director { get; set; }

    public virtual ICollection<LeaUser> Admins { get; set; }
    
    public virtual ICollection<Group> Groups { get; set; }

    public virtual ICollection<Lector> Lectors { get; set; }

    public virtual ICollection<Lector> Students { get; set; }


}
