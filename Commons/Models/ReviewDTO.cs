using System;

namespace Commons.Models;

public class ReviewDTO
{
	public int Id { get; set; }
	public string Description { get; set; }
	public double Rating { get; set; }
	public string Date { get; set; }
	public string User { get; set; }
}

