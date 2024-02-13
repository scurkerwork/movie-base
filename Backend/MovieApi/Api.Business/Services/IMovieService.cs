using Api.Business.DTOs;

namespace Api.Business.Services
{
    /// <summary>
    /// Service interface for managing movies.
    /// </summary>
    public interface IMovieService
    {
        /// <summary>
        /// Retrieves a movie by its ID from the repository.
        /// </summary>
        /// <param name="id">The ID of the movie to retrieve.</param>
        /// <returns>An API response containing the movie with the specified ID.</returns>
        Task<ApiResponse<MovieDto>> GetByIdAsync(int id);

        /// <summary>
        /// Retrieves all movies from the repository.
        /// </summary>
        /// <returns>An API response containing a list of all movies.</returns>
        Task<ApiResponse<List<MovieDto>>> GetAllAsync();

        /// <summary>
        /// Adds a new movie to the repository.
        /// </summary>
        /// <param name="movie">The movie DTO to add.</param>
        /// <returns>An API response indicating the result of the operation.</returns>
        Task<ApiResponse<MovieDto>> AddAsync(CreateMovieDto movie);

        /// <summary>
        /// Updates an existing movie in the repository.
        /// </summary>
        /// <param name="movie">The movie DTO to update.</param>
        Task UpdateAsync(CreateMovieDto movie);

        /// <summary>
        /// Deletes a movie from the repository.
        /// </summary>
        /// <param name="id">The ID of the movie to delete.</param>
        Task DeleteAsync(int id);
    }
}
