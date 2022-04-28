using Lea.Data.Common;
using Lea.Data.Entities.Tests;

namespace Lea.Data.Entities.Core;

public class Group : LeaEntity
{
    public string Name { get; set; }

    public string BackgroundImageUrl { get; set; }

    public virtual Course Course { get; set; }

    public virtual ICollection<Lector> Lectors { get; set; }

    public virtual ICollection<Student> Students { get; set; }

    public virtual ICollection<UpcomingTest> UpcomingTests { get; set; }

}
