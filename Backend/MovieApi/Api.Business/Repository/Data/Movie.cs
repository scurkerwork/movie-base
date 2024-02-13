namespace Api.Business.Repository.Data
{
    /// <summary>
    /// Represents a movie entity.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Gets or sets the unique identifier for the movie.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the movie.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the year of release of the movie.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets the collection of actors associated with the movie.
        /// </summary>
        public ICollection<Actor> Actors { get; set; }

        /// <summary>
        /// Gets or sets the collection of ratings associated with the movie.
        /// </summary>
        public ICollection<MovieRating> Ratings { get; set; }
    }
}
