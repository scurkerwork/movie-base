using Api.Business;
using Api.Business.Defintions;

namespace Api.Utils
{
    /// <summary>
    /// Dependency Injection
    /// </summary>
    internal sealed class DependencyInjection : IBootstrapper<IServiceCollection, SettingsProvider>
    {
        /// <summary>
        /// Dependencies registration
        /// </summary>
        /// <param name="servicesContainer">.NET Core build-in container</param>
        /// <param name="configuration">.NET Core build-in configuration</param>
        public void Bootstrap(IServiceCollection servicesContainer, SettingsProvider configuration)
        {
            servicesContainer.AddSingleton<IServiceProvider>(servicesContainer.BuildServiceProvider());
            servicesContainer.RegisterBusinessApplicationServices()
                             .RegisterBusinessRepositories(configuration);
        }
    }
}
