using Lea.Data.Common;

namespace Lea.Data.Entities;

public class Teacher : LeaEntity
{
    public virtual ICollection<Class> Classes { get; set; }

    public virtual ICollection<Folder> Folders { get; set; }

    public virtual School School { get; set; }
}
