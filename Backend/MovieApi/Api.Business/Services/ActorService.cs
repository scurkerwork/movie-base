using Api.Business.DTOs;
using Api.Business.Repository;
using Api.Business.Repository.Data;
using AutoMapper;

namespace Api.Business.Services
{
    /// <summary>
    /// Service for managing actors.
    /// </summary>
    public class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the ActorService class.
        /// </summary>
        /// <param name="actorRepository">The actor repository.</param>
        /// <param name="mapper">The AutoMapper instance.</param>
        public ActorService(IActorRepository actorRepository, IMapper mapper)
        {
            _actorRepository = actorRepository ?? throw new ArgumentNullException(nameof(actorRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Adds a new actor to the repository.
        /// </summary>
        /// <param name="movie">The actor DTO to add.</param>
        /// <returns>An API response indicating the result of the operation.</returns>
        public Task<ApiResponse<Actor>> AddAsync(ActorDto movie)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes an actor from the repository.
        /// </summary>
        /// <param name="id">The ID of the actor to delete.</param>
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves all actors from the repository.
        /// </summary>
        /// <returns>An API response containing a list of all actors.</returns>
        public Task<ApiResponse<List<Actor>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves actors by their IDs from the repository.
        /// </summary>
        /// <param name="ids">The IDs of the actors to retrieve.</param>
        /// <returns>An API response containing a list of actors with the specified IDs.</returns>
        public async Task<ApiResponse<List<Actor>>> GetByIdsAsync(IEnumerable<int> ids)
        {
            List<Actor> data = await _actorRepository.GetByIdsAsync(ids);
            bool exist = data.Any();
            return new ApiResponse<List<Actor>>()
            {
                Data = data,
                Success = exist,
                StatusCode = exist ? 200 : 400
            };
        }

        /// <summary>
        /// Updates an existing actor in the repository.
        /// </summary>
        /// <param name="movie">The actor DTO to update.</param>
        public Task UpdateAsync(ActorDto movie)
        {
            throw new NotImplementedException();
        }
    }
}
