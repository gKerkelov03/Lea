using Data.Common;
using Data.Entities.Identity;

namespace Data.Entities.Core;

public class Course : LeaEntity
{
    public string Name { get; set; }

    public string PictureUrl { get; set; }

    public virtual Guid DirectorId { get; set; }

    public virtual LeaUser Director { get; set; }

    public virtual ICollection<LeaUser> Admins { get; set; }

    public virtual ICollection<Group> Groups { get; set; }
}
