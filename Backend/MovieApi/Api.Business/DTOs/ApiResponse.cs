namespace Api.Business.DTOs
{
    /// <summary>
    /// Represents the response returned from API operations.
    /// </summary>
    /// <typeparam name="T">The type of data associated with the response.</typeparam>
    public class ApiResponse<T>
    {
        /// <summary>
        /// Gets or sets a value indicating whether the operation was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets the data associated with the response.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Gets or sets the error message associated with the response.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets the list of errors associated with the response.
        /// </summary>
        public List<string> Errors { get; set; }

        /// <summary>
        /// Gets or sets the status code associated with the response.
        /// </summary>
        public int StatusCode { get; set; }
    }
}
