﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SE.Data.Models;
using StudySpace.Data.Base;

namespace SE.Data.Repository
{
    public class NotificationRepository : GenericRepository<Notification>
    {
        public NotificationRepository() { }
        public NotificationRepository(SeniorEssentialsContext context)
        {
            _context = context;
        }
    }
}
