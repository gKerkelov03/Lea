using Lea.Data.Common;
using Lea.Data.Entities.Examination;

namespace Lea.Data.Entities.Core;

public class Group : LeaEntity
{
    public string Name { get; set; }

    public string PictureUrl { get; set; }

    public virtual Course Course { get; set; }

    public virtual ICollection<Lector> Lectors { get; set; }

    public virtual ICollection<Student> Students { get; set; }

    public virtual ICollection<UpcomingExam> UpcomingTests { get; set; }

}
