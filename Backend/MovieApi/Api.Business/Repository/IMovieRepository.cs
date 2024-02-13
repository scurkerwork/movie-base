using Api.Business.Repository.Data;

namespace Api.Business.Repository
{
    /// <summary>
    /// Interface for accessing movie data in the repository.
    /// </summary>
    public interface IMovieRepository
    {
        /// <summary>
        /// Retrieves a movie asynchronously by its ID.
        /// </summary>
        /// <param name="id">The ID of the movie to retrieve.</param>
        /// <returns>A task representing the asynchronous operation, with the movie.</returns>
        Task<Movie> GetByIdAsync(int id);

        /// <summary>
        /// Retrieves all movies asynchronously.
        /// </summary>
        /// <returns>A task representing the asynchronous operation, with the list of all movies.</returns>
        Task<List<Movie>> GetAllAsync();

        /// <summary>
        /// Adds a movie asynchronously to the repository.
        /// </summary>
        /// <param name="movie">The movie to add.</param>
        /// <returns>A task representing the asynchronous operation, with the added movie.</returns>
        Task<Movie> AddAsync(Movie movie);

        /// <summary>
        /// Updates an existing movie asynchronously.
        /// </summary>
        /// <param name="movie">The movie to update.</param>
        /// <returns>A task representing the asynchronous operation, with the updated movie.</returns>
        Task<Movie> UpdateAsync(Movie movie);

        /// <summary>
        /// Deletes a movie asynchronously by its ID.
        /// </summary>
        /// <param name="id">The ID of the movie to delete.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task DeleteAsync(int id);
    }
}
