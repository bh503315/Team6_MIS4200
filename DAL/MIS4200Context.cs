﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Team6_MIS4200.Models;
using System.Data.Entity;

namespace Team6_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base ("name=DefaultConnection")
        {

        }
        public DbSet<Employees> Employees { get; set; }

        public DbSet<Recognition> Recognition { get; set; }
    }
}