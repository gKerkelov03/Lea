using Data.Common;
using Data.Entities.Examination;

namespace Data.Entities.Core;

public class Group : LeaEntity
{
    public string Name { get; set; }

    public string PictureUrl { get; set; }

    public Guid CourseId { get; set; }
    public virtual Course Course { get; set; }

    public virtual ICollection<Lector> Lectors { get; set; }

    public virtual ICollection<Student> Students { get; set; }










    public virtual ICollection<UpcomingExam> UpcomingExams { get; set; }

    public virtual ICollection<PastExam> PastExams { get; set; }
}
