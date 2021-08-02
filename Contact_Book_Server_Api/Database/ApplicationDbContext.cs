﻿using Domain;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ContactEntity> ContactEntities { get; set; }

        public DbSet<ContactEntityCategory> ContactEntityCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.CreateIdentityRoles();

            modelBuilder.CreateContactEntities();
            modelBuilder.CreateContactEntityCategories();
        }
    }
}
