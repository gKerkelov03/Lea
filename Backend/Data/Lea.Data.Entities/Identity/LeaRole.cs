using Lea.Data.Entities.Core;
using Microsoft.AspNetCore.Identity;

namespace Lea.Data.Entities.Identity;

public class LeaRole : IdentityRole<Guid>
{
    public LeaRole() => Id = Guid.NewGuid();

    public virtual Course Course { get; set; }

    public virtual ICollection<LeaUser> Users { get; set; }
}
