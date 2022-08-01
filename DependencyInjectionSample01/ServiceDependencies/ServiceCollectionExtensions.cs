using DependencyInjectionSample01.Repository;

namespace DependencyInjectionSample01.ServiceDependencies
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient <IMovieRepository, MovieRepository> ();
        }
    }
}
