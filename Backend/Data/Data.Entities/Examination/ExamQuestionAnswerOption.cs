using Data.Common;

namespace Data.Entities.Examination;

public class ExamQuestionAnswerOption : LeaEntity
{
    public string Text { get; set; }

    public bool IsCorrect { get; set; }

    public bool IsSelected { get; set; }

    public virtual ExamQuestion Question { get; set; }
}
