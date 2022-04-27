using Lea.Data.Common;

namespace Lea.Data.Entities;

public class Folder : LeaEntity
{
    public string Name { get; set; }

    public virtual ICollection<Question> Questions { get; set; }

    public virtual ICollection<Folder> Folders { get; set; }
}
