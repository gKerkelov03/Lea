using Lea.Data.Common;
using Lea.Data.Entities.Core;

namespace Lea.Data.Entities.Examination;

public class PastExam : LeaEntity
{
    public string Name { get; set; }

    public virtual ICollection<ExamQuestion> Questions { get; set; }

    public int QuestionsCount { get; set; }

    public virtual Group Class { get; set; }

    public virtual Lector Creator { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }
}