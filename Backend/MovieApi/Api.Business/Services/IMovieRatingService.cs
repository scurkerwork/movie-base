using Api.Business.DTOs;

namespace Api.Business.Services
{
    /// <summary>
    /// Service interface for managing movie ratings.
    /// </summary>
    public interface IMovieRatingService
    {
        /// <summary>
        /// Retrieves a movie rating by its ID from the repository.
        /// </summary>
        /// <param name="id">The ID of the movie rating to retrieve.</param>
        /// <returns>An API response containing the movie rating with the specified ID.</returns>
        Task<ApiResponse<MovieRatingDto>> GetByIdAsync(int id);

        /// <summary>
        /// Retrieves all movie ratings from the repository.
        /// </summary>
        /// <returns>An API response containing a list of all movie ratings.</returns>
        Task<ApiResponse<MovieRatingDto>> GetAllAsync();

        /// <summary>
        /// Adds a new movie rating to the repository.
        /// </summary>
        /// <param name="movie">The movie rating DTO to add.</param>
        /// <returns>An API response indicating the result of the operation.</returns>
        Task<ApiResponse<MovieRatingDto>> AddAsync(MovieRatingDto movie);

        /// <summary>
        /// Updates an existing movie rating in the repository.
        /// </summary>
        /// <param name="movie">The movie rating DTO to update.</param>
        Task UpdateAsync(MovieRatingDto movie);

        /// <summary>
        /// Deletes a movie rating from the repository.
        /// </summary>
        /// <param name="id">The ID of the movie rating to delete.</param>
        Task DeleteAsync(int id);
    }
}
