using Microsoft.EntityFrameworkCore;

namespace Api.Business.Repository.Data
{
    /// <summary>
    /// Represents the database context for the application.
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataContext"/> class.
        /// </summary>
        /// <param name="options">The options for this context.</param>
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // DbSet properties for database tables
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<MovieRating> MovieRatings { get; set; }

        /// <summary>
        /// Overrides the configuration of the model that was defined using Fluent API.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Data seeding
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Movie 1", Year = 2020 },
                new Movie { Id = 2, Title = "Movie 2", Year = 2019 }
            );

            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1, Name = "Actor 1" },
                new Actor { Id = 2, Name = "Actor 2" }
            );

            modelBuilder.Entity<MovieRating>().HasData(
                new MovieRating { Id = 1, MovieId = 1, Rating = 4 },
                new MovieRating { Id = 2, MovieId = 2, Rating = 5 }
            );
        }
    }
}
