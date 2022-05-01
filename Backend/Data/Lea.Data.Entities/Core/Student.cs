﻿using Lea.Data.Common;
using Lea.Data.Entities.Examination;
using Lea.Data.Entities.Identity;

namespace Lea.Data.Entities.Core;

public class Student : LeaEntity
{
    public string Name { get; set; }

    public virtual Course School { get; set; }

    public virtual LeaUser User { get; set; }

    public virtual ICollection<PastExam> PastTests { get; set; }

    public virtual ICollection<Group> Groups { get; set; }
}
