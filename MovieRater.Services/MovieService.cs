using MovieRater.Data;
using MovieRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Services
{
    class MovieService
    {
        public bool CreateMovie(MovieCreate model)
        {
            var entity =
                new Movie()
                {
                    Title = model.Title,
                    Description = model.Description,
                    CriticRating = model.CriticRating,
                    MaturityRating = model.MaturityRating
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Movies.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<MovieListItem> GetMovies()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Movies
                        .Select(
                            e =>
                            new MovieListItem
                            {
                                MovieId = e.MovieId,
                                Title = e.Title,
                                Description = e.Description,
                                CriticRating = e.CriticRating,
                                MaturityRating = e.MaturityRating
                            }
                        );
                return query.ToArray();
            }
        }
    }
}
