using System;
using Commons.Models;

namespace BussinesLogic.Interfaces
{
	public interface IReviewRepository
	{
		Task<ReviewDTO> AddReview( ReviewDTI reviewDTI);
		List<ReviewDTO> GetListReview(int movieId);
	}
}
