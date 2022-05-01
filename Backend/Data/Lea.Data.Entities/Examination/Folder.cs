using Lea.Data.Common;

namespace Lea.Data.Entities.Examination;

public class Folder : LeaEntity
{
    public string Name { get; set; }

    public virtual ICollection<ExamQuestion> Questions { get; set; }

    public virtual ICollection<Folder> Folders { get; set; }
}
