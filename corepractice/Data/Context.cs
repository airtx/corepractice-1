using corepractice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace corepractice.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Group> Group { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User").HasKey(e => e.UserId);
            modelBuilder.Entity<Group>().ToTable("Group").HasKey(e => e.GroupId);
        }
    }
}
