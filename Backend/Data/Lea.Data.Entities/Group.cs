using Lea.Data.Common;

namespace Lea.Data.Entities;

public class Group : LeaEntity
{
    public string Name { get; set; }

    public string BackgroundImageUrl { get; set; }

    public virtual Course Course { get; set; }

    public virtual ICollection<Lector> Lectors { get; set; }

    public virtual ICollection<Student> Students { get; set; }

    public virtual ICollection<UpcomingTest> UpcomingTests { get; set; }

}
