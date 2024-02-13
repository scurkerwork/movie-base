using Api.Business.Repository.Data;

namespace Api.Business.Repository
{
    /// <summary>
    /// Interface for accessing actor data in the repository.
    /// </summary>
    public interface IActorRepository
    {
        /// <summary>
        /// Retrieves a list of actors asynchronously based on the provided IDs.
        /// </summary>
        /// <param name="ids">The IDs of the actors to retrieve.</param>
        /// <returns>A task representing the asynchronous operation, with the list of actors.</returns>
        Task<List<Actor>> GetByIdsAsync(IEnumerable<int> ids);

        /// <summary>
        /// Retrieves all actors asynchronously.
        /// </summary>
        /// <returns>A task representing the asynchronous operation, with the list of all actors.</returns>
        Task<List<Actor>> GetAllAsync();

        /// <summary>
        /// Adds an actor asynchronously to the repository.
        /// </summary>
        /// <param name="actor">The actor to add.</param>
        /// <returns>A task representing the asynchronous operation, with the added actor.</returns>
        Task<Actor> AddAsync(Actor actor);

        /// <summary>
        /// Updates an existing actor asynchronously.
        /// </summary>
        /// <param name="actor">The actor to update.</param>
        /// <returns>A task representing the asynchronous operation, with the updated actor.</returns>
        Task<Actor> UpdateAsync(Actor actor);

        /// <summary>
        /// Deletes an actor asynchronously by its ID.
        /// </summary>
        /// <param name="id">The ID of the actor to delete.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task DeleteAsync(int id);
    }
}
