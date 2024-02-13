namespace Api.Business.Repository.Data
{
    /// <summary>
    /// Represents a movie rating entity.
    /// </summary>
    public class MovieRating
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
        /// Gets or sets the movie associated with the rating.
        /// </summary>
        public Movie Movie { get; set; }

        /// <summary>
        /// Gets or sets the rating value.
        /// </summary>
        public int Rating { get; set; }
    }
}
