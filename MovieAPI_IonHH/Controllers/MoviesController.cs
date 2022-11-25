using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace MovieAPI_IonHH.Controllers;

[ApiController]
[Route("[controller]")]
public class MoviesController : ControllerBase
{
    [HttpPost(Name = "CreateMovie")]
    public IActionResult CreateMovie()
    {
        return Ok("Testing");
    }

    [HttpGet("{movieId}", Name = "GetMovie")]
    public IActionResult GetMovie()
    {
        return Ok("Testing");
    }

    [HttpGet(Name = "MoviesList")]
    public IActionResult MoviesList(string? sort, int? page  )
    {
        return Ok();
    }

    [HttpDelete("{movieId}/disabled", Name = "DisableMovie")]
    public IActionResult DisableMovie()
    {
        return Ok("Testing");
    }
}

