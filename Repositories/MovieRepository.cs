using RepoUnitTestPoc.Models;
using RepoUnitTestPoc.Repositories.Abstractions;

namespace RepoUnitTestPoc.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        
        public MovieRepository()
        {

        }


        public Movie Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Movie> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
