namespace Api.Business.Repository.Data
{
    /// <summary>
    /// Represents an actor entity.
    /// </summary>
    public class Actor
    {
        /// <summary>
        /// Gets or sets the unique identifier for the actor.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the actor.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the collection of movies associated with the actor.
        /// </summary>
        public ICollection<Movie> Movies { get; set; }
    }
}
