using Api.Business.Repository.Data;

namespace Api.Business.Repository
{
    /// <summary>
    /// Repository for managing movies.
    /// </summary>
    public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _context;

        /// <summary>
        /// Initializes a new instance of the MovieRepository class.
        /// </summary>
        /// <param name="context">The data context.</param>
        public MovieRepository(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// Adds a new movie to the repository.
        /// </summary>
        /// <param name="movie">The movie to add.</param>
        /// <returns>The added movie.</returns>
        public async Task<Movie> AddAsync(Movie movie)
        {
            if (movie == null)
            {
                throw new ArgumentNullException(nameof(movie));
            }

            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<Movie> movieData = await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
            return movieData.Entity;
        }

        /// <summary>
        /// Deletes a movie from the repository.
        /// </summary>
        /// <param name="id">The ID of the movie to delete.</param>
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves all movies from the repository.
        /// </summary>
        /// <returns>A list of all movies.</returns>
        public Task<List<Movie>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves a movie by its ID from the repository.
        /// </summary>
        /// <param name="id">The ID of the movie to retrieve.</param>
        /// <returns>The movie with the specified ID.</returns>
        public Task<Movie> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates an existing movie in the repository.
        /// </summary>
        /// <param name="movie">The movie to update.</param>
        /// <returns>The updated movie.</returns>
        public Task<Movie> UpdateAsync(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
