﻿using Lea.Data.Common;
using Lea.Data.Entities.Identity;

namespace Lea.Data.Entities.Core;

public class Course : LeaEntity
{
    public string Title { get; set; }    

    public string PictureUrl { get; set; }

    public virtual LeaUser Director { get; set; }

    public virtual ICollection<LeaUser> Admins { get; set; }

    public virtual ICollection<Group> Groups { get; set; }

    public virtual ICollection<Lector> Lectors { get; set; }

    public virtual ICollection<Student> Students { get; set; }
}
