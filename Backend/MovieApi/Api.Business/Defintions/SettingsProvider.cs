namespace Api.Business.Defintions
{
    /// <summary>
    /// Provider for application settings.
    /// </summary>
    public class SettingsProvider
    {
        /// <summary>
        /// Gets or sets the logging settings.
        /// </summary>
        public Logging Logging { get; set; }

        /// <summary>
        /// Gets or sets the allowed hosts.
        /// </summary>
        public string AllowedHosts { get; set; }

        /// <summary>
        /// Gets or sets the CORS origin.
        /// </summary>
        public string CorsOrigin { get; set; }

        /// <summary>
        /// Gets or sets the connection strings.
        /// </summary>
        public ConnectionStrings ConnectionStrings { get; set; }
    }

    /// <summary>
    /// Represents logging levels.
    /// </summary>
    public class LogLevel
    {
        /// <summary>
        /// Gets or sets the default logging level.
        /// </summary>
        public string Default { get; set; }

        /// <summary>
        /// Gets or sets the logging level for Microsoft.AspNetCore components.
        /// </summary>
        public string MicrosoftAspNetCore { get; set; }
    }

    /// <summary>
    /// Represents logging settings.
    /// </summary>
    public class Logging
    {
        /// <summary>
        /// Gets or sets the logging level.
        /// </summary>
        public LogLevel LogLevel { get; set; }
    }

    /// <summary>
    /// Represents connection strings.
    /// </summary>
    public class ConnectionStrings
    {
        /// <summary>
        /// Gets or sets the default connection string.
        /// </summary>
        public string DefaultConnection { get; set; }
    }
}
