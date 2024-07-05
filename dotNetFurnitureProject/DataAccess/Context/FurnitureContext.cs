using System;
using dotNetFurnitureProject.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace dotNetFurnitureProject.DataAccess.Context
{
	public class FurnitureContext : IdentityDbContext<AppUser,AppRole,int>
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=DotNetFurnitureDb;Username=postgres;password=1234;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<UserMessage> UserMessages { get; set; }
    }
}

