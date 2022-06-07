using System;
using Marvel.Entities;
using Microsoft.EntityFrameworkCore;

namespace Marvel.DAL.Data
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext()
        {
        }

        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost;Database=Marvel;User Id=SA;Password=P@ssword1;");
        }

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<User_Hero> UsersHeroes { get; set; }
    }
}
