using Lea.Data.Common;

namespace Lea.Data.Entities.Secondary;

public class TestAnswerOption : LeaEntity
{
    public string Text { get; set; }

    public bool IsCorrect { get; set; }

    public bool IsSelected { get; set; }

    public virtual TestQuestion Question { get; set; }
}
