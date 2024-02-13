using Api.Business.Repository.Data;

namespace Api.Business.Repository
{
    /// <summary>
    /// Interface for accessing movie rating data in the repository.
    /// </summary>
    public interface IMovieRatingRepository
    {
        /// <summary>
        /// Retrieves a movie rating asynchronously by its ID.
        /// </summary>
        /// <param name="id">The ID of the movie rating to retrieve.</param>
        /// <returns>A task representing the asynchronous operation, with the movie rating.</returns>
        Task<MovieRating> GetByIdAsync(int id);

        /// <summary>
        /// Retrieves all movie ratings asynchronously.
        /// </summary>
        /// <returns>A task representing the asynchronous operation, with the list of all movie ratings.</returns>
        Task<List<MovieRating>> GetAllAsync();

        /// <summary>
        /// Adds a movie rating asynchronously to the repository.
        /// </summary>
        /// <param name="actor">The movie rating to add.</param>
        /// <returns>A task representing the asynchronous operation, with the added movie rating.</returns>
        Task<MovieRating> AddAsync(MovieRating actor);

        /// <summary>
        /// Updates an existing movie rating asynchronously.
        /// </summary>
        /// <param name="actor">The movie rating to update.</param>
        /// <returns>A task representing the asynchronous operation, with the updated movie rating.</returns>
        Task<MovieRating> UpdateAsync(MovieRating actor);

        /// <summary>
        /// Deletes a movie rating asynchronously by its ID.
        /// </summary>
        /// <param name="id">The ID of the movie rating to delete.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task DeleteAsync(int id);
    }
}
