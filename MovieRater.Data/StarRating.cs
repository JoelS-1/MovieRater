using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Data
{
    public class StarRating
    {
        [Key]
        public int StarRatingId { get; set; }

        [Required]
        [Range(0, 5)]
        public int StarRatingNumber { get; set; }

        [ForeignKey(nameof(Movie))]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [ForeignKey(nameof(Show))]
        public int ShowId { get; set; }
        public Show Show { get; set; }
    }
}
