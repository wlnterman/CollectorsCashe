using KursCollection.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KursCollection.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Theme> Themes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<IdentityUser>()
            //    .ToTable("AspNetUsers", t => t.ExcludeFromMigrations());

            base.OnModelCreating(modelBuilder);     //https://stackoverflow.com/questions/40703615/the-entity-type-identityuserloginstring-requires-a-primary-key-to-be-defined

            modelBuilder.Entity<Comment>()          //https://docs.microsoft.com/en-us/ef/core/saving/cascade-delete
                .HasOne(u => u.AppUser)
                .WithMany(c => c.Comments)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Like>()
                .HasOne(u => u.AppUser)
                .WithMany(l => l.Likes)
                .OnDelete(DeleteBehavior.ClientCascade);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("" +
                "Host=ec2-52-30-67-143.eu-west-1.compute.amazonaws.com;" +
                "Port=5432;" +
                "Database=dehep17tvubrp5;" +
                "Username=gxsjgrvjkfhlhz;" +
                "Password=abfbc336ffd5c3c0a84ce64b21ff3a0b2399dd480d70d8d6777ccb5f6ff6973e;" +
                "sslmode=Require;" +
                "Trust Server Certificate=true;");
        }

        //public ApplicationDbContext()
        //    : base()
        //{
        //}

    }
}

