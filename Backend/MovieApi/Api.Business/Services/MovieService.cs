using Api.Business.DTOs;
using Api.Business.Repository;
using Api.Business.Repository.Data;
using AutoMapper;

namespace Api.Business.Services
{
    /// <summary>
    /// Service class for managing movie-related operations.
    /// </summary>
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IActorService _actorService;
        private readonly IMapper _mapper;

        public MovieService(IMovieRepository movieRepository, IActorService actorService, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _actorService = actorService;
            _mapper = mapper;
        }

        /// <summary>
        /// Adds a new movie asynchronously.
        /// </summary>
        /// <param name="movie">The movie DTO containing the movie information.</param>
        /// <returns>An asynchronous task with the result of the operation.</returns>
        public async Task<ApiResponse<MovieDto>> AddAsync(CreateMovieDto movie)
        {
            // Map CreateMovieDto to Movie entity
            Movie newMovie = _mapper.Map<Movie>(movie);

            // Validate actor IDs
            if (movie.ActorIds != null && movie.ActorIds.Any())
            {
                ApiResponse<List<Actor>> actor = await _actorService.GetByIdsAsync(movie.ActorIds);

                if (actor.Data.Count != movie.ActorIds.Count)
                {
                    // Return error response if not all actors are found
                    return new ApiResponse<MovieDto>()
                    {
                        ErrorMessage = $"No actors found with the provided IDs: {string.Join(", ", movie.ActorIds)}",
                        Success = false,
                        StatusCode = 400
                    };
                }
                else
                {
                    newMovie.Actors = actor.Data;
                }
            }

            // Add the new movie to the repository
            Movie addedMovie = await _movieRepository.AddAsync(newMovie);

            // Map the added movie entity back to MovieDto
            MovieDto newMovieDto = _mapper.Map<MovieDto>(addedMovie);

            // Return success response with the added movie DTO
            return new ApiResponse<MovieDto>()
            {
                Success = true,
                Data = newMovieDto,
                StatusCode = 201
            };
        }

        /// <summary>
        /// Deletes a movie asynchronously by its ID.
        /// </summary>
        /// <param name="id">The ID of the movie to delete.</param>
        /// <returns>An asynchronous task representing the operation.</returns>
        public async Task DeleteAsync(int id)
        {
            // TODO: Implement delete operation
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves all movies asynchronously.
        /// </summary>
        /// <returns>An asynchronous task with the list of movies.</returns>
        public async Task<ApiResponse<List<MovieDto>>> GetAllAsync()
        {
            // TODO: Implement get all operation
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves a movie by its ID asynchronously.
        /// </summary>
        /// <param name="id">The ID of the movie to retrieve.</param>
        /// <returns>An asynchronous task with the movie DTO.</returns>
        public async Task<ApiResponse<MovieDto>> GetByIdAsync(int id)
        {
            // TODO: Implement get by ID operation
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates an existing movie asynchronously.
        /// </summary>
        /// <param name="movie">The movie DTO containing the updated information.</param>
        /// <returns>An asynchronous task representing the operation.</returns>
        public async Task UpdateAsync(CreateMovieDto movie)
        {
            // TODO: Implement update operation
            throw new NotImplementedException();
        }
    }
}
