using Lea.Data.Common;

namespace Lea.Data.Entities.Secondary;

public class TestQuestion : LeaEntity
{
    public string Description { get; set; }

    public virtual ICollection<TestAnswerOption> Options { get; set; }

    public virtual TestAnswerOption CorrectAnswer { get; set; }
}
