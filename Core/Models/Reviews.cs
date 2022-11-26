using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models;

public class Reviews
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int ReviewId { get; set; }

	public string Description { get; set; }

	public double Rating { get; set; }

	public string User { get; set; }

	public DateTime Date { get; set; }

	public bool IsDeleted { get; set; }

	public int MovieId { get; set; }

	public virtual Movies? Movie { get; set; }

}

