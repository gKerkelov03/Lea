using Services.Data.Models.Core;

namespace Services.Data.Models.Identity;

public class LeaRoleServiceModel : BaseServiceModel
{
    public LeaRoleServiceModel() => Id = Guid.NewGuid();

    public Guid CourseId { get; set; }

    public virtual CourseServiceModel Course { get; set; }

    public virtual ICollection<LeaRoleServiceModel> Users { get; set; }
}
