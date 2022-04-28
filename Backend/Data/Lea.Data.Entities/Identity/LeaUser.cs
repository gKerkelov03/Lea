using Microsoft.AspNetCore.Identity;

namespace Lea.Data.Entities.Identity;

public class LeaUser : IdentityUser<Guid>
{
    public string ProfilePictureUrl { get; set; }

    public string Name { get; set; }
}
