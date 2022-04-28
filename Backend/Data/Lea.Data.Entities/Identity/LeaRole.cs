using Lea.Data.Entities.Core;
using Microsoft.AspNetCore.Identity;

namespace Lea.Data.Entities.Identity;

public class LeaRole : IdentityRole<Guid>
{
    public virtual Course Course { get; set; }
}
