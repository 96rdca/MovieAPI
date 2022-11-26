using System;

namespace Commons.Models;

public class ReviewDTI
{
	public int MovieId { get; set; }
	public string? Description { get; set; }
	public double Rating { get; set; }
	public string User { get; set; }
}
