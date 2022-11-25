using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Commons.Models;


namespace MovieAPI_IonHH.Controllers;

[ApiController]
[Route("[controller]")]
public class ReviewController : ControllerBase
{
    //private readonly ILogger<WeatherForecastController> _logger;

    //public WeatherForecastController(ILogger<WeatherForecastController> logger)
    //{
    //    _logger = logger;
    //}

    [HttpGet("{movieId}",Name = "GetReviews")]
    public IActionResult Reviews()
    {
        return Ok();
    }

    [HttpPost("{movieId}", Name = "AddReview")]
    public IActionResult AddReview(ReviewDTI review)
    {
        if (string.IsNullOrEmpty(review.Review))
        {
            return BadRequest("Empty object");
        }

        return CreatedAtAction(nameof(AddReview), Request.RouteValues, review);
    }
}

