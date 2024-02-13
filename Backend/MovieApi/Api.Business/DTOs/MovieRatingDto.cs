namespace Api.Business.DTOs
{
    /// <summary>
    /// Data transfer object for representing a movie rating.
    /// </summary>
    public class MovieRatingDto
    {
        /// <summary>
        /// Gets or sets the unique identifier for the movie rating.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the movie associated with the rating.
        /// </summary>
        public int MovieId { get; set; }

        /// <summary>
        /// Gets or sets the rating given to the movie.
        /// </summary>
        public int Rating { get; set; }
    }
}
