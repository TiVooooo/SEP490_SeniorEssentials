﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace SE.Data.Models;

public partial class Notification
{
    public int NotificationId { get; set; }

    public int AccountId { get; set; }

    public string Title { get; set; }

    public string Message { get; set; }

    public string NotificationType { get; set; }

    public DateTime CreatedDate { get; set; }

    public string Status { get; set; }

    public virtual Account Account { get; set; }
}