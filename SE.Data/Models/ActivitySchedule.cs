﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace SE.Data.Models;

public partial class ActivitySchedule
{
    public int ActivityScheduleId { get; set; }

    public int ActivityId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string Status { get; set; }

    public virtual Activity Activity { get; set; }
}