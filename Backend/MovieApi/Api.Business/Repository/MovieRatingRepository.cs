using Api.Business.Repository.Data;
using Microsoft.EntityFrameworkCore;

namespace Api.Business.Repository
{
    /// <summary>
    /// Repository for managing movie ratings.
    /// </summary>
    public class MovieRatingRepository : IMovieRatingRepository
    {
        private readonly DataContext _context;

        /// <summary>
        /// Initializes a new instance of the MovieRatingRepository class.
        /// </summary>
        /// <param name="context">The data context.</param>
        public MovieRatingRepository(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// Adds a new movie rating to the repository.
        /// </summary>
        /// <param name="rating">The movie rating to add.</param>
        /// <returns>The added movie rating.</returns>
        public async Task<MovieRating> AddAsync(MovieRating rating)
        {
            if (rating == null)
            {
                throw new ArgumentNullException(nameof(rating));
            }

            _context.MovieRatings.Add(rating);
            await _context.SaveChangesAsync();
            return rating;
        }

        /// <summary>
        /// Deletes a movie rating from the repository.
        /// </summary>
        /// <param name="id">The ID of the movie rating to delete.</param>
        public async Task DeleteAsync(int id)
        {
            MovieRating rating = await GetByIdAsync(id);
            if (rating != null)
            {
                _context.MovieRatings.Remove(rating);
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Retrieves all movie ratings from the repository.
        /// </summary>
        /// <returns>A list of all movie ratings.</returns>
        public async Task<List<MovieRating>> GetAllAsync()
        {
            return await _context.MovieRatings.ToListAsync();
        }

        /// <summary>
        /// Retrieves a movie rating by its ID from the repository.
        /// </summary>
        /// <param name="id">The ID of the movie rating to retrieve.</param>
        /// <returns>The movie rating with the specified ID.</returns>
        public async Task<MovieRating> GetByIdAsync(int id)
        {
            return await _context.MovieRatings.FindAsync(id);
        }

        /// <summary>
        /// Updates an existing movie rating in the repository.
        /// </summary>
        /// <param name="rating">The movie rating to update.</param>
        /// <returns>The updated movie rating.</returns>
        public async Task<MovieRating> UpdateAsync(MovieRating rating)
        {
            if (rating == null)
            {
                throw new ArgumentNullException(nameof(rating));
            }

            _context.Entry(rating).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return rating;
        }
    }
}
