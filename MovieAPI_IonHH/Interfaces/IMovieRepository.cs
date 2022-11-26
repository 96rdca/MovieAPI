using System;
using Commons;
using Commons.Models;

namespace BussinesLogic.Interfaces
{
	public interface IMovieRepository
	{
		Task<MovieDTO> AddMovie(MovieDTI movieDTI);

		Task<bool> DisableMovie(int movieId);

		MovieDTO GetMovie(int movieId);

        PagedList<List<MovieDTO>> GetListMovies(MovieParameters movieParameters);
	}
}

