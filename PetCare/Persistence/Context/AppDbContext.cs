﻿using Microsoft.EntityFrameworkCore;
using PetCare.Domain.Models;
using PetCare.Persistence.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetCare.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<ServicesProvider> ServicesProviders { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Plan> Plans { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            new CustomerConfig(builder.Entity<Customer>());
            new ServicesProviderConfig(builder.Entity<ServicesProvider>());
            new PlanConfig(builder.Entity<Plan>());

            //
          builder.Entity<Plan>().HasMany(x => x.ListServicesProvider).
              WithOne(x => x.Plan).HasForeignKey(x => x.PlanId);

            builder.Entity<Plan>().HasData
            (
                new Plan { Id = 1, Name = "Basica", Description = "Plan Basico", Price = 19.90, Duration = 1 },
                new Plan { Id = 2, Name = "Premium", Description = "Plan Premium", Price = 39.90, Duration = 1 }
            );
        }
    }
}
