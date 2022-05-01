using Lea.Data.Common;

namespace Lea.Data.Entities.Examination;

public class ExamQuestion : LeaEntity
{
    public string Description { get; set; }

    public virtual ICollection<ExamQuestionAnswerOption> Options { get; set; }

    public virtual ExamQuestionAnswerOption CorrectAnswer { get; set; }
}
