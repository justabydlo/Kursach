using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Kursach.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
    }
}
