using Microsoft.EntityFrameworkCore;
using Resturants.Domain.Entities;


namespace Resturants.Infra.Persistant;

    internal class ResturantDBContext : DbContext
    {
       internal DbSet<Resturant> Resturants { get; set; }
       internal DbSet<Dish> Dishes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

}

