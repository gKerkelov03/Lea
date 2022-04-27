using Lea.Data.Common;

namespace Lea.Data.Entities;

public class Test : LeaEntity
{
    public string Name { get; set; }

    public virtual ICollection<Question> Questions { get; set; }

    public int QuestionsCount { get; set; }

    public virtual Class Class { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }
}
