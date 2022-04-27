using Lea.Data.Common;

namespace Lea.Data.Entities;

public class UpcomingTest : LeaEntity
{
    public string Name { get; set; }

    public int QuestionsCount { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public virtual Group Class { get; set; }

    public virtual Lector Creator { get; set; }

    public virtual ICollection<Question> Questions { get; set; }


}
