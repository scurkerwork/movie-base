using Api.Business.DTOs;
using Api.Business.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    /// <summary>
    /// Controller for managing movie-related HTTP operations.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : BaseHandlingController
    {
        private readonly IMovieService _movieService;
        private readonly ILogger<MoviesController> _logger;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="MoviesController"/> class.
        /// </summary>
        /// <param name="movieService">The movie service for handling movie-related operations.</param>
        /// <param name="mapper">The AutoMapper instance for mapping between DTOs and entities.</param>
        /// <param name="logger">The logger for logging information.</param>
        public MoviesController(IMovieService movieService, IMapper mapper, ILogger<MoviesController> logger)
        {
            _movieService = movieService;
            _mapper = mapper;
            _logger = logger;
        }

        /// <summary>
        /// Adds a new movie.
        /// </summary>
        /// <param name="movieDto">The DTO containing the movie information.</param>
        /// <returns>An action result indicating the outcome of the operation.</returns>
        [ProducesResponseType(typeof(ApiResponse<MovieDto>), 201)]
        [ProducesResponseType(typeof(ApiResponse<MovieDto>), 400)]
        [ProducesResponseType(typeof(ApiResponse<MovieDto>), 401)]
        [HttpPost]
        public async Task<ActionResult<ApiResponse<MovieDto>>> AddMovie([FromBody] CreateMovieDto movieDto)
        {
            try
            {
                // Handle model validation errors
                ActionResult<ApiResponse<MovieDto>> validationErrorResult = HandleValidationErrors<MovieDto>();
                if (validationErrorResult != null)
                {
                    return validationErrorResult;
                }

                // Add the movie using the movie service
                ApiResponse<MovieDto> data = await _movieService.AddAsync(movieDto);

                // Check if the operation was successful
                if (data.Success)
                {
                    // Return 201 Created status with the added movie DTO
                    return CreatedAtAction(nameof(AddMovie), new { id = data.Data.Id }, data);
                }
                else
                {
                    // Return 400 Bad Request with the error response
                    return BadRequest(data);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions and return appropriate response
                return GetResultByException(ex);
            }
        }
    }
}
