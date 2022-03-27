using api.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Domain.Context;

public class OnePieceDbContext : DbContext
{
    public OnePieceDbContext()
    {
    }

    public OnePieceDbContext(DbContextOptions<OnePieceDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Pirate>()
            .HasData(
                new Pirate
                {
                    Id = 1, FirstName = "Monkey", LastName = "D. Luffy,", Crew = "Mugiwara Pirates", Rank = "Captain", Ship = "Sunny"
                },
                new Pirate
                {
                    Id = 2, FirstName = "Roronoa", LastName = "Zoro", Crew = "Mugiwara Pirates", Rank = "Immediate", Ship = "Sunny"
                },
                new Pirate {Id = 3, FirstName = "Nami", LastName = "", Crew = "Mugiwara Pirates", Rank = "Navigator", Ship = "Sunny"},
                new Pirate {Id = 4, FirstName = "Usopp", LastName = "God", Crew = "Mugiwara Pirates", Rank = "Shooter", Ship = "Sunny"},
                new Pirate {Id = 5, FirstName = "Chopper", LastName = "", Crew = "Mugiwara Pirates", Rank = "Medic", Ship = "Sunny"},
                new Pirate {Id = 6, FirstName = "Sanji", LastName = "", Crew = "Mugiwara Pirates", Rank = "Cook", Ship = "Sunny"},
                new Pirate {Id = 7, FirstName = "Franky", LastName = "", Crew = "Mugiwara Pirates", Rank = "Mechanic", Ship = "Sunny"},
                new Pirate {Id = 8, FirstName = "Brook", LastName = "", Crew = "Mugiwara Pirates", Rank = "Musician", Ship = "Sunny"}
            );
    }

    public DbSet<Pirate> Pirate { get; set; }
}