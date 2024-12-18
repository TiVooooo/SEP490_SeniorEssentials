﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace SE.Data.Models;

public partial class ProfessorSchedule
{
    public int ProfessorScheduleId { get; set; }

    public int ProfessorId { get; set; }

    public DateOnly ScheduleDate { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public string Status { get; set; }

    public virtual Professor Professor { get; set; }

    public virtual ICollection<ProfessorAppointment> ProfessorAppointments { get; set; } = new List<ProfessorAppointment>();
}