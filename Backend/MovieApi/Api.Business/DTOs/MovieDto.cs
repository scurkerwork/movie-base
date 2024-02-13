using System.ComponentModel.DataAnnotations;

namespace Api.Business.DTOs
{
    /// <summary>
    /// Data transfer object for creating a movie.
    /// </summary>
    public class CreateMovieDto
    {
        /// <summary>
        /// Unique identifier for the movie.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The title of the movie.
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// The year of release of the movie.
        /// </summary>
        [Range(1900, 2100, ErrorMessage = "Please enter a valid year between 1900 and 2100.")]
        public int Year { get; set; }

        /// <summary>
        /// List of actor IDs associated with the movie.
        /// </summary>
        public List<int>? ActorIds { get; set; }
    }

    /// <summary>
    /// Data transfer object for a movie.
    /// </summary>
    public class MovieDto
    {
        /// <summary>
        /// Unique identifier for the movie.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The title of the movie.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The year of release of the movie.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// List of actors associated with the movie.
        /// </summary>
        public List<ActorDto>? Actors { get; set; }

        /// <summary>
        /// List of ratings associated with the movie.
        /// </summary>
        public List<MovieRatingDto>? MovieRatings { get; set; }
    }
}
