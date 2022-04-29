using RepoUnitTestPoc.Models;

namespace RepoUnitTestPoc.Repositories.Abstractions
{
    public interface IMovieRepository
    {
        Movie Get(int id);
        IEnumerable<Movie> GetAll();
    }
}
