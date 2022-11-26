using System;
using BussinesLogic.Interfaces;
using Commons.Models;
using MovieAPI_IonHH.Context;

namespace MovieAPI_IonHH.Repository
{
	public class MovieRepository : IMovieRepository
	{
        private readonly AppDbContext _Context;

        public MovieRepository(AppDbContext context)
		{
			_Context = context;
		}

        public Task<MovieDTO> AddMovie(MovieDTI movieDTI)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DisableMovie(int movieId)
        {
            throw new NotImplementedException();
        }

        public List<MovieDTO> GetListMovies()
        {
            throw new NotImplementedException();
        }

        public MovieDTO GetMovie(int movieId)
        {
            throw new NotImplementedException();
        }
    }
}

