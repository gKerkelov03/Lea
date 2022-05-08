using Data.Common;
using Data.Entities.Core;

namespace Data.Entities.Examination;

public class UpcomingExam : LeaEntity
{
    public string Name { get; set; }

    public int QuestionsCount { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public virtual Group Class { get; set; }

    public virtual Lector Creator { get; set; }

    public virtual ICollection<ExamQuestion> Questions { get; set; }
}
