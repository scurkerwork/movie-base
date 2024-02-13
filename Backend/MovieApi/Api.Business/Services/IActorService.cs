using Api.Business.DTOs;
using Api.Business.Repository.Data;

namespace Api.Business.Services
{
    /// <summary>
    /// Service interface for managing actors.
    /// </summary>
    public interface IActorService
    {
        /// <summary>
        /// Retrieves actors by their IDs from the repository.
        /// </summary>
        /// <param name="ids">The IDs of the actors to retrieve.</param>
        /// <returns>An API response containing a list of actors with the specified IDs.</returns>
        Task<ApiResponse<List<Actor>>> GetByIdsAsync(IEnumerable<int> ids);

        /// <summary>
        /// Retrieves all actors from the repository.
        /// </summary>
        /// <returns>An API response containing a list of all actors.</returns>
        Task<ApiResponse<List<Actor>>> GetAllAsync();

        /// <summary>
        /// Adds a new actor to the repository.
        /// </summary>
        /// <param name="movie">The actor DTO to add.</param>
        /// <returns>An API response indicating the result of the operation.</returns>
        Task<ApiResponse<Actor>> AddAsync(ActorDto movie);

        /// <summary>
        /// Updates an existing actor in the repository.
        /// </summary>
        /// <param name="movie">The actor DTO to update.</param>
        Task UpdateAsync(ActorDto movie);

        /// <summary>
        /// Deletes an actor from the repository.
        /// </summary>
        /// <param name="id">The ID of the actor to delete.</param>
        Task DeleteAsync(int id);
    }
}
