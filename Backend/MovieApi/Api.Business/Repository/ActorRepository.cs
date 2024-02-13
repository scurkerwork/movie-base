using Api.Business.Repository.Data;
using Microsoft.EntityFrameworkCore;

namespace Api.Business.Repository
{
    /// <summary>
    /// Repository class for managing actor data.
    /// </summary>
    public class ActorRepository : IActorRepository
    {
        private readonly DataContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public ActorRepository(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Adds an actor asynchronously.
        /// </summary>
        /// <param name="actor">The actor to add.</param>
        /// <returns>A task representing the asynchronous operation, with the added actor.</returns>
        public Task<Actor> AddAsync(Actor actor)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks if the provided actor IDs are valid.
        /// </summary>
        /// <param name="actorIds">The actor IDs to validate.</param>
        /// <returns>True if all actor IDs are valid, false otherwise.</returns>
        public async Task<bool> AreActorIdsValid(IEnumerable<int> actorIds)
        {
            // Retrieve existing actor IDs from the database
            List<int> existingActorIds = await _context.Actors
                .Where(actor => actorIds.Contains(actor.Id))
                .Select(actor => actor.Id)
                .ToListAsync();

            // Check if the count of existing actor IDs matches the count of provided actor IDs
            return existingActorIds.Count == actorIds.Count();
        }

        /// <summary>
        /// Deletes an actor asynchronously by ID.
        /// </summary>
        /// <param name="id">The ID of the actor to delete.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves all actors asynchronously.
        /// </summary>
        /// <returns>A task representing the asynchronous operation, with the list of all actors.</returns>
        public Task<List<Actor>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves actors asynchronously by their IDs.
        /// </summary>
        /// <param name="ids">The IDs of the actors to retrieve.</param>
        /// <returns>A task representing the asynchronous operation, with the list of actors matching the provided IDs.</returns>
        public async Task<List<Actor>> GetByIdsAsync(IEnumerable<int> ids)
        {
            // Retrieve actors from the database based on the provided IDs
            return await _context.Actors
                .Where(actor => ids.Contains(actor.Id))
                .ToListAsync();
        }

        /// <summary>
        /// Updates an actor asynchronously.
        /// </summary>
        /// <param name="actor">The actor to update.</param>
        /// <returns>A task representing the asynchronous operation, with the updated actor.</returns>
        public Task<Actor> UpdateAsync(Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}
