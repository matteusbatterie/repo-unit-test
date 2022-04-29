
using RepoUnitTestPoc.Models;
using RepoUnitTestPoc.Repositories.Abstractions;
using RepoUnitTestPoc.Services.Abstractions;

namespace RepoUnitTestPoc.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _repository;

        public MovieService(IMovieRepository repository)
        {
            _repository = repository;
        }


        public Movie Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Movie> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
