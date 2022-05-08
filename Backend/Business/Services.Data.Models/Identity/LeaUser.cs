using Services.Data.Models.Core;

namespace Services.Data.Models.Identity;

public class LeaUserServiceModel : BaseServiceModel
{
    public LeaUserServiceModel() => Id = Guid.NewGuid();

    public string ProfilePictureUrl { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public Guid StudentId { get; set; }

    public virtual StudentServiceModel Student { get; set; }

    public Guid LectorId { get; set; }

    public virtual LectorServiceModel Lector { get; set; }

    public virtual ICollection<LeaRoleServiceModel> Roles { get; set; }
}
