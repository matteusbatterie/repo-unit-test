
using RepoUnitTestPoc.Repositories;
using RepoUnitTestPoc.Repositories.Abstractions;
using RepoUnitTestPoc.Services;
using RepoUnitTestPoc.Services.Abstractions;

namespace RepoUnitTestPoc.Util.Startup
{
    public static class StartupExtension
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.MapServices();
            services.MapRepositories();
        }


        private static void MapServices(this IServiceCollection services)
        {
            services.AddScoped<IMovieService, MovieService>();
        }

        private static void MapRepositories(this IServiceCollection services)
        {
            services.AddScoped<IMovieRepository, MovieRepository>();
        }
    }
}
