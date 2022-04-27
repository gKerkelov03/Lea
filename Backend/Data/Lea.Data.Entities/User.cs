using Lea.Data.Common;

namespace Lea.Data.Entities;

public class User : LeaEntity
{
    public string Name { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public virtual ICollection<Role> Roles { get; set; }
}
