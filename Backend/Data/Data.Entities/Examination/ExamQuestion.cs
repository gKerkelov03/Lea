using Data.Common;

namespace Data.Entities.Examination;

public class ExamQuestion : LeaEntity
{
    public string MediaUrl { get; set; }

    public string Description { get; set; }

    public virtual ICollection<ExamQuestionAnswerOption> Options { get; set; }

    //public virtual ExamQuestionAnswerOption CorrectAnswer { get; set; }
}
