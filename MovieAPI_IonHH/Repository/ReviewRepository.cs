using System;
using BussinesLogic.Interfaces;
using Commons.Models;
using Core.Models;
using MovieAPI_IonHH.Context;

namespace MovieAPI_IonHH.Repository
{
	public class ReviewRepository : IReviewRepository
	{
        private readonly AppDbContext _Context;
		public ReviewRepository(AppDbContext context)
		{
            _Context = context;
		}

        public async Task<ReviewDTO> AddReview(ReviewDTI reviewDTI)
        {
            try
            {
                if (string.IsNullOrEmpty(reviewDTI.Description))
                    throw new Exception("the field description cant be null or empty");

                if (!_Context.Movies.Any(x => x.MovieId == reviewDTI.MovieId))
                    throw new Exception("the movie does not exist on database");

                var reviewToAdd = new Reviews
                {   MovieId = reviewDTI.MovieId,
                    User = reviewDTI.User,
                    Description = reviewDTI.Description,
                    Rating = reviewDTI.Rating,
                    Date = DateTime.Now,
                    IsDeleted = false
                };

                _Context.Reviews.Add(reviewToAdd);
                await _Context.SaveChangesAsync();

                return new ReviewDTO
                {
                    Id = reviewToAdd.ReviewId,
                    Description =reviewToAdd.Description,
                    Rating = reviewToAdd.Rating,
                    Date = reviewToAdd.Date.ToShortDateString(),
                    User = reviewToAdd.User
                };
            }
            catch (Exception ex)
            {
#if DEBUG
                Console.WriteLine(ex);
#endif
                throw new Exception("An error has ocurred while saving");
            }
        }

        public List<ReviewDTO> GetListReview(int movieId)
        {
            try
            {
                var listReview = _Context.Reviews.Where(x => !x.IsDeleted && x.MovieId == movieId).Select(x => new ReviewDTO
                {
                    Id = x.ReviewId,
                    Description = x.Description,
                    Date = x.Date.ToShortDateString(),
                    Rating = x.Rating,
                    User = x.User
                }).ToList();

                return listReview;

            }
            catch (Exception ex)
            {
#if DEBUG
                Console.WriteLine(ex);
#endif
                throw new Exception("An error has ocurred while fetching data");
            }
        }
    }
}

