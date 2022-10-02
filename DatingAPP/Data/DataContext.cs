﻿using DatingApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingAPP.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }
    }
}
