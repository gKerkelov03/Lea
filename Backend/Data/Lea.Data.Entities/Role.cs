using Lea.Data.Common;

namespace Lea.Data.Entities;

public class Role : LeaEntity
{
    public string Name { get; set; }    

    public virtual School School { get; set; }
}
