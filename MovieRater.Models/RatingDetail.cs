using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models
{
    public class RatingDetail
    {
        public int RatingId { get; set; }
        public int StarRating { get; set; }

        public int? MovieId { get; set; }
    }
}
