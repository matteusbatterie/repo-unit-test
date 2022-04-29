using RepoUnitTestPoc.Models;

namespace RepoUnitTestPoc.Services.Abstractions
{
    public interface IMovieService
    {
        Movie Get(int id);
        IEnumerable<Movie> GetAll();
    }
}
