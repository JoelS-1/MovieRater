using MovieRater.Data;
using MovieRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Services
{
    public class ShowService
    {
        private readonly Guid _userId;
        public ShowService(Guid userId)
        {
            _userId = userId;
        }
    }

    public bool CreateShow(ShowCreate model)
    {
        var entity =
            new Show()
            {
                OwnerId = _userId,
                Title = model.Title,
                Description = model.Description,
                MaturityRating = model.MaturityRating

            };

        using var ctx = new ApplicationDbContext()){
            var query =
                ctx
                    .Shows
                    .Where(eh => e.OwnerId == _userId)
                    .Select(
                        e =>
                            new ShowListItem
                            {
                                ShowId = e.ShowId,
                                Title = e.Title,
                                Description = e.Description,
                                MaturityRating = e.MaturityRating
                            }
                                );
        }
    }
}
