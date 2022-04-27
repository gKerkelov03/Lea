using Microsoft.AspNetCore.Identity;

namespace Lea.Data.Entities;

public class LeaRole : IdentityRole<Guid>
{      
    public virtual Course Course { get; set; }
}
