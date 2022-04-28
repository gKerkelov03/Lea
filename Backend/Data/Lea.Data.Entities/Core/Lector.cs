using Lea.Data.Common;
using Lea.Data.Entities.Secondary;

namespace Lea.Data.Entities.Core;

public class Lector : LeaEntity
{
    public virtual Course Course { get; set; }

    public virtual ICollection<Group> Groups { get; set; }

    public virtual ICollection<Folder> Folders { get; set; }

}
