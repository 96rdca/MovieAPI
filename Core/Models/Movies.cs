using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models;

public class Movies
{
    public Movies()
    {
        this.Reviews = new HashSet<Reviews>();
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MovieId { get; set; }

    public string Title { get; set; }
    public string Overview { get; set; }
    public string Year { get; set; }
    public int Runtime { get; set; }
    public bool IsDeleted { get; set; }

    public virtual ICollection<Reviews> Reviews { get; set; }
}

