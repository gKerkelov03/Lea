using Lea.Data.Entities.Core;
using Microsoft.AspNetCore.Identity;

namespace Lea.Data.Entities.Identity;

public class LeaUser : IdentityUser<Guid>
{
    public LeaUser() => Id = Guid.NewGuid();

    public string ProfilePictureUrl { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public virtual Student Student { get; set; }

    public virtual Lector Lector { get; set; }

    public virtual ICollection<LeaRole> Roles { get; set; }
}
