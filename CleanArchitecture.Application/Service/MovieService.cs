using CleanArchitecture.Application.IRepository;
using CleanArchitecture.Application.IService;
using CleanArchitecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Service
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository movieRepository;

        public MovieService(IMovieRepository _movieRepository)
        {
            movieRepository = _movieRepository;
        }
        public List<Movie> GetAllMovies()
        {
            var movies = movieRepository.GetAllMovies();

            return movies;
        }
    }
}
