using MovieRater.Data;
using MovieRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Services
{
    public class RatingService
    {
        public bool RatingCreate(RatingCreate model)
        {
            var entity =
                new StarRating()
                {
                    StarRatingNumber = model.StarRatingNumber
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.StarRating.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public RatingDetail GetStarRatingById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Ratings
                        .Single(e => e.CategoryId == id);
                return
                    new RatingDetail
                    {
                        RatingId = entity.RatingId,
                        StarRating = entity.StarRating
                    };
            }
        }
    }
}
