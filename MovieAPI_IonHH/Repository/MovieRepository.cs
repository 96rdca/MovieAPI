using System;
using System.Reflection;
using System.Text;
using BussinesLogic.Interfaces;
using Commons.Models;
using Core.Models;
using System.Linq.Dynamic.Core;
using MovieAPI_IonHH.Context;
using Commons;
using LinqKit;
using System.Linq.Expressions;

namespace MovieAPI_IonHH.Repository
{
	public class MovieRepository : IMovieRepository
	{
        private readonly AppDbContext _Context;

        public MovieRepository(AppDbContext context)
		{
			_Context = context;
		}

        public async Task<MovieDTO> AddMovie(MovieDTI movieDTI)
        {
            try
            {
                var movieToAdd = new Movies
                {
                    Title = movieDTI.Title,
                    Overview = movieDTI.Overview,
                    Runtime = movieDTI.RunTime,
                    Year = movieDTI.Year,
                    IsDeleted = false
                };

                _Context.Movies.Add(movieToAdd);
                await _Context.SaveChangesAsync();

                return new MovieDTO
                {
                    MovieId = movieToAdd.MovieId,
                    Overview = movieToAdd.Overview,
                    Runtime = movieToAdd.Runtime,
                    Title = movieToAdd.Title,
                    Year = movieToAdd.Year
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

        public async Task<bool> DisableMovie(int movieId)
        {
            try
            {
                var toDisaled = _Context.Movies.FirstOrDefault(x => x.MovieId == movieId);

                if (toDisaled is null)
                    throw new Exception("movie not found");

                toDisaled.IsDeleted = true;

                return await _Context.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
#if DEBUG
                Console.WriteLine(ex);
#endif
                throw new ("An error has ocurred while deleting the movie");
            }
        }

        public PagedList<List<MovieDTO>> GetListMovies(MovieParameters movieParameters)
        {
            try
            {
                var filter = CreateFilter( movieParameters);

                var movies = _Context.Movies
                    .Where(filter)
                    .Skip((movieParameters.PageNumber - 1) * movieParameters.PageSize)
                    .Take(movieParameters.PageSize);

                var totalRecords = _Context.Movies.Count(filter);
                    
                ApplySort(ref movies, movieParameters.OrderBy);

                var moviesDTO = movies.Select(Map).ToList();

                return new PagedList<List<MovieDTO>>(moviesDTO, totalRecords, movieParameters.PageNumber, movieParameters.PageSize);
                    
            }
            catch (Exception ex)
            {
#if DEBUG
                Console.WriteLine(ex);
#endif
                throw new("An error has ocurred while fetching the movies");
            }
        }

        public MovieDTO GetMovie(int movieId)
        {
            try
            {
                var movie = _Context.Movies.FirstOrDefault(x => x.MovieId == movieId && !x.IsDeleted);

                if (movie is null)
                    throw new Exception("the movie was not found");

                return new MovieDTO
                {
                    MovieId = movie.MovieId,
                    Overview= movie.Overview,
                    Runtime = movie.Runtime,
                    Title = movie.Title,
                    Year = movie.Year
                };
            }
            catch (Exception ex)
            {
#if DEBUG
                Console.WriteLine(ex);
#endif
                throw new("An error has ocurred while fetching the movie");
            }
        }

        private MovieDTO Map(Movies movies)
        {
            return new MovieDTO
            {
                MovieId = movies.MovieId,
                Title = movies.Title,
                Overview = movies.Overview,
                Runtime = movies.Runtime,
                Year = movies.Year
            };
        }

        private static Expression<Func<Movies, bool>> CreateFilter(MovieParameters movieParameters)
        {
            var predicate = PredicateBuilder.New<Movies>().And(x => !x.IsDeleted);

            if (!string.IsNullOrEmpty(movieParameters.Title))
                predicate = predicate.And(x => x.Title.Contains(movieParameters.Title));
            else if (movieParameters.Runtime > 0)
                predicate = predicate.And(x => x.Runtime == movieParameters.Runtime);
            else if (!string.IsNullOrEmpty(movieParameters.Year))
                predicate = predicate.And(x => x.Year == movieParameters.Year);

            return predicate;
        }

        private void ApplySort(ref IQueryable<Movies> movies, string orderByQueryString)
        {
            if (!movies.Any())
                return;

            if (string.IsNullOrEmpty(orderByQueryString))
            {
                movies = movies.OrderBy(x => x.MovieId);
                return;
            }

            var orderParams = orderByQueryString.Trim().Split(',');
            var propertyInfos = typeof(Movies).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var orderQueryBuilder = new StringBuilder();

            foreach (var param in orderParams)
            {
                if (string.IsNullOrWhiteSpace(param))
                    continue;

                var propertyFromQueryName = param.Split(" ")[0];
                var objectProperty = propertyInfos.FirstOrDefault(pi => pi.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase));
                if (objectProperty == null)
                    continue;

                var sortingOrder = param.EndsWith(" desc") ? "descending" : "ascending";
                orderQueryBuilder.Append($"{objectProperty.Name.ToString()} {sortingOrder}, ");
            }

            var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');

            if (string.IsNullOrWhiteSpace(orderQuery))
            {
                movies = movies.OrderBy(x => x.MovieId);
                return;
            }
            movies = movies.OrderBy(orderQuery);
        }
    }
}

