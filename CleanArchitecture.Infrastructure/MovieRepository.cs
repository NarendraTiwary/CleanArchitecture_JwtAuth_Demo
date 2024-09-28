using CleanArchitecture.Application.IRepository;
using CleanArchitecture.Domain;

namespace CleanArchitecture.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        private static List<Movie> movies = new List<Movie>()
        {
            new Movie(1, "M1", 100),
            new Movie(2,"M2",2000),
            new Movie(3, "M3", 150)
        };

        public List<Movie> GetAllMovies()
        {
            return movies;

        }
    }
}
