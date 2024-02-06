using MoviesTracker.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesTracker.Application.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly List<Movie> _movie = new List<Movie>();
        public Task<bool> CreateAsync(Movie movie)
        {
            _movie.Add(movie);
            return Task.FromResult(true);
        }

        public Task<bool> DeleteByIdAsync(Guid id)
        {
            var removedCount = _movie.RemoveAll(x => x.Id == id);
            var moviesRemoved = removedCount > 0;
            return Task.FromResult(moviesRemoved);
        }

        public Task<IEnumerable<Movie>> GetAllAsync()
        {
            return Task.FromResult(_movie.AsEnumerable());
        }

        public Task<Movie?> GetByIdAsync(Guid id)
        {
            var movie = _movie.SingleOrDefault(x => x.Id == id);
            return Task<Movie?>.FromResult(movie);
        }

        public Task<bool> UpdateAsync(Movie movie)
        {
            var movieIndex = _movie.FindIndex(x => x.Id == movie.Id);

            if (movieIndex == -1)
            {
                return Task.FromResult(false);
            }

            _movie[movieIndex] = movie;
            return Task.FromResult(true);
        }
    }
}
