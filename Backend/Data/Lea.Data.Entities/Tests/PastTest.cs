using Lea.Data.Common;
using Lea.Data.Entities.Core;
using Lea.Data.Entities.Secondary;

namespace Lea.Data.Entities.Tests;

public class PastTest : LeaEntity
{
    public string Name { get; set; }

    public virtual ICollection<TestQuestion> Questions { get; set; }

    public int QuestionsCount { get; set; }

    public virtual Group Class { get; set; }

    public virtual Lector Creator { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }
}