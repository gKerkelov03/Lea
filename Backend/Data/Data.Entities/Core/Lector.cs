using Data.Common;
using Data.Entities.Examination;
using Data.Entities.Identity;

namespace Data.Entities.Core;

public class Lector : LeaEntity
{
    public Guid UserId { get; set; }
    public virtual LeaUser User { get; set; }

    public virtual ICollection<Group> Groups { get; set; }










    public virtual ICollection<Folder> Folders { get; set; }
}
