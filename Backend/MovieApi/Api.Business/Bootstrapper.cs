using Api.Business.Defintions;
using Api.Business.Repository;
using Api.Business.Repository.Data;
using Api.Business.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Business
{
    /// <summary>
    /// Dependency injection Interface
    /// </summary>
    /// <typeparam name="TServicesContainer">Type .NET Core Build-in container</typeparam>
    /// <typeparam name="ISettingsProvider">Type .NET Core Build-in configuration</typeparam>
    public interface IBootstrapper<in TServicesContainer, in ISettingsProvider>
    {
        /// <summary>
        /// Dependencies(services and repositories) registration
        /// </summary>
        /// <param name="servicesContainer">.NET Core Build-in container</param>
        /// <param name="configuration">.NET Core Build-in configuration</param>
        void Bootstrap(TServicesContainer servicesContainer, ISettingsProvider configuration);
    }

    /// <summary>
    /// Handles dependency Injection
    /// </summary>
    public static class Bootstrapper
    {
        #region // public methods

        /// <summary>
        /// Registration of business services
        /// </summary>
        /// <param name="servicesContainer">.NET Core Build-in container</param>
        /// <param name="settings">Reference to the settings provider</param>
        /// <returns>Retruns container with registered services</returns>
        public static IServiceCollection RegisterBusinessApplicationServices(this IServiceCollection servicesContainer)
        {
            // new instance will be provided to every controller and every service            
            servicesContainer.AddTransient<IMovieService, MovieService>();
            servicesContainer.AddTransient<IActorService, ActorService>();
            servicesContainer.AddTransient<IMovieRatingService, MovieRatingService>();

            // objects are the same for every object and every request
            return servicesContainer;
        }

        /// <summary>
        /// Registration of repositories
        /// </summary>
        /// <param name="servicesContainer">.NET Core Build-in container</param>
        /// <param name="settings">Reference to the settings provider</param>
        /// <returns>Return container with registered repositories</returns>
        public static IServiceCollection RegisterBusinessRepositories(this IServiceCollection servicesContainer, SettingsProvider settings)
        {
            // new instance will be provided to every controller and every service
            servicesContainer.AddTransient<IMovieRepository, MovieRepository>();
            servicesContainer.AddTransient<IActorRepository, ActorRepository>();
            servicesContainer.AddTransient<IMovieRatingRepository, MovieRatingRepository>();

            servicesContainer.AddDbContext<DataContext>(options => options.UseSqlServer(settings.ConnectionStrings.DefaultConnection));

            return servicesContainer;
        }

        #endregion 
    }
}
