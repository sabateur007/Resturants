using Microsoft.EntityFrameworkCore;
using Resturants.Domain.Entities;
using System;


namespace Resturants.Infra.Persistant;

    internal class ResturantDBContext : DbContext
    {
       internal DbSet<Resturant> Resturants { get; set; }
       internal DbSet<Dish> Dishes { get; set; }

    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-P1S3DJU\\MYSQLLOCALDB;Initial Catalog=Resturants;Integrated Security=True;Trust Server Certificate=True");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Resturant>()
             .OwnsOne(r => r.Address);
        modelBuilder.Entity<Resturant>()
            .HasMany(r => r.Dishes)
            .WithOne()
            .HasForeignKey(d => d.ResturantID);

    }



    }

