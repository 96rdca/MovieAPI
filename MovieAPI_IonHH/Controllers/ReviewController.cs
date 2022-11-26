using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Commons.Models;
using BussinesLogic.Interfaces;

namespace MovieAPI_IonHH.Controllers;

[ApiController]
[Route("[controller]")]
public class ReviewController : ControllerBase
{
    private readonly IReviewRepository _reviewRepository;
    //private readonly ILogger<WeatherForecastController> _logger;

    //public WeatherForecastController(ILogger<WeatherForecastController> logger)
    //{
    //    _logger = logger;
    //}

    public ReviewController(IReviewRepository reviewRepository)
    {
        _reviewRepository = reviewRepository;
    }

    [HttpGet("{movieId}",Name = "GetReviews")]
    public IActionResult Reviews(int movieId)
    {
        try
        {
            var reviews = _reviewRepository.GetListReview(movieId);
            return Ok(reviews);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost( Name = "AddReview")]
    public async Task<IActionResult> AddReview(ReviewDTI review)
    {
        try
        {
            var reviewAdd = await _reviewRepository.AddReview(review);
            return Created( nameof(AddReview), reviewAdd);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}

