using Lea.Data.Common;

namespace Lea.Data.Entities;

public class Question : LeaEntity
{
    public string Description { get; set; }

    public virtual ICollection<AnswerOption> Options { get; set; }

    public virtual AnswerOption CorrectAnswer { get; set; }   
}
