using System;
using Egeroro.Entity.Concrete;
using Egeroro.Entity.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Egeroro.Data.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        public Context()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=MERTVICTUS\\SQLEXPRESS;Database=Egeroro;Trusted_Connection=True;");
        }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Fleet> Fleets { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<OurExpertise> OurExpertises { get; set; }
        public DbSet<OurServices> OurServices { get; set; }
        public DbSet<OurTeam> OurTeams { get; set; }
    }
}

