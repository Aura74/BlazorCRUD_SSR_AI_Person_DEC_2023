using BlazorCRUDSSR_AI_DEC_2023.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDSSR_AI_DEC_2023.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VideoGame>().HasData(
                new VideoGame { Id = 1, Title = "CyberPunk", Publisher = "CD Project", ReleaseYear = 1998},
                new VideoGame { Id = 2, Title = "ElderRing", Publisher = "XXXXXXRE", ReleaseYear = 1999 },
                new VideoGame { Id = 3, Title = "Zelda", Publisher = "Nintendo", ReleaseYear = 1988 }

                );
        }

        public DbSet<VideoGame> VideoGames { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}

//https://www.youtube.com/watch?v=EqSgqm4qWjo
