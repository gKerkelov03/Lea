using Lea.Data.Common;
using Lea.Data.Entities.Examination;
using Lea.Data.Entities.Identity;

namespace Lea.Data.Entities.Core;

public class Lector : LeaEntity
{   
    public virtual LeaUser User { get; set; }

    public virtual ICollection<Group> Groups { get; set; }










    public virtual ICollection<Folder> Folders { get; set; }
}
