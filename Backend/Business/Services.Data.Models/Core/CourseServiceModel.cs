using Data.Entities.Core;
using Mappings.Conventions;
using Services.Data.Models.Identity;

namespace Services.Data.Models.Core;

public class CourseServiceModel : BaseServiceModel, IMapToAndFrom<Course>
{
    public string Name { get; set; }

    public string PictureUrl { get; set; }

    public virtual Guid DirectorId { get; set; }

    public virtual LeaUserServiceModel Director { get; set; }

    public virtual ICollection<LeaUserServiceModel> Admins { get; set; }

    public virtual ICollection<Group> Groups { get; set; }
}