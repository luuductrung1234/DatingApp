﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {

        public DbSet<Value> Values { get; set; }

        public DbSet<User> Users { get; set; }
        
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
