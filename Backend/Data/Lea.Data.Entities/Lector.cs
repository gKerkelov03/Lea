using Lea.Data.Common;

namespace Lea.Data.Entities;

public class Lector : LeaEntity
{
    public virtual Course Course { get; set; }

    public virtual ICollection<Group> Groups { get; set; }

    public virtual ICollection<Folder> Folders { get; set; }

}
