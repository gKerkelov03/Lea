using Lea.Data.Common;

namespace Lea.Data.Entities.Secondary;

public class Folder : LeaEntity
{
    public string Name { get; set; }

    public virtual ICollection<TestQuestion> Questions { get; set; }

    public virtual ICollection<Folder> Folders { get; set; }
}
