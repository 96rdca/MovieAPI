using System;
namespace Commons
{
	public class MovieParameters : QueryStringParameters
	{
		public MovieParameters()
		{
			OrderBy = "MovieId";
		}

		public string? Title { get; set; }
		public string? Year { get; set; }
		public int? Runtime { get; set; }
	}
}

