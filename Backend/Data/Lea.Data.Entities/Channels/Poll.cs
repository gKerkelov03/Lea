﻿using Lea.Data.Common;
using Lea.Data.Entities.Core;

namespace Lea.Data.Entities.Channels;

public class Poll : LeaEntity
{
    public string Question { get; set; }

    public virtual Group Group { get; set; }

    public virtual ICollection<PollOption> Options { get; set; }
}