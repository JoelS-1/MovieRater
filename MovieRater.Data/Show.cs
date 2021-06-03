using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Data
{
	public enum MaturityRating { G = 1, PG, PG_13, R, TV_G, TV_PG, TV_14, TV_MA }
	public class Show
	{
		[Key]
		public int ShowId { get; set; }

		[Required]
		public string Title { get; set; }
		public string Description { get; set; }
		public double StarRating { get; set; }

		//[Required]
		//public GenreType TypeOfGenre { get; set; }

		[Required]
		public MaturityRating MaturityRating { get; set; }
		public bool isFamilyFriendly
		{
			get
			{
				if (MaturityRating == MaturityRating.R || MaturityRating == MaturityRating.TV_MA)
				{
					return false;
				}
				else
				{
					return true;
				}
			}
		}
	}
}
