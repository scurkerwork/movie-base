namespace Api.Business.DTOs
{
    /// <summary>
    /// Data transfer object for representing an actor.
    /// </summary>
    public class ActorDto
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
        public ICollection<MovieDto> Movies { get; set; }
    }
}
