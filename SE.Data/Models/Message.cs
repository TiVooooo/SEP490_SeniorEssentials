﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace SE.Data.Models;

public partial class Message
{
    public int MessageId { get; set; }

    public int ChatId { get; set; }

    public int SenderId { get; set; }

    public string MessageContent { get; set; }

    public DateTime SendTime { get; set; }

    public bool IsRead { get; set; }

    public string Status { get; set; }

    public virtual Chat Chat { get; set; }

    public virtual Account Sender { get; set; }
}