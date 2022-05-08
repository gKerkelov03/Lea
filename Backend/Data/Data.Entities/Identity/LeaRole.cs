using Data.Entities.Core;
using Microsoft.AspNetCore.Identity;

namespace Data.Entities.Identity;

public class LeaRole : IdentityRole<Guid>
{
    public LeaRole() => Id = Guid.NewGuid();

    public Guid CourseId { get; set; }

    public virtual Course Course { get; set; }

    public virtual ICollection<LeaUser> Users { get; set; }
}
