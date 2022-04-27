using Lea.Data.Common;

namespace Lea.Data.Entities;

public class Question : LeaEntity
{
    public string Description { get; set; }

    public virtual ICollection<Class> Options { get; set; }

    public virtual Class CorrectAnswer { get; set; }

    public virtual Class SelectedAnswer { get; set; }
}
