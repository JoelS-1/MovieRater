using MovieRater.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models
{
    public class ShowCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "This title has too many characters for this field.")]
        public string Title { get; set; }

        [MaxLength(8000)]
        public string Description { get; set; }
        //public double StarRating { get; set; }
        public MaturityRating MaturityRating { get; set; }
    }
}
