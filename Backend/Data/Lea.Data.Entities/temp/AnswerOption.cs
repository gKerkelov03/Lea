using Lea.Data.Common;

namespace Lea.Data.Entities;

public class AnswerOption : LeaEntity
{
    public string Text { get; set; }

    public bool IsCorrect { get; set; }

    public bool IsSelected { get; set; }

    public virtual Question Question { get; set; }
}
