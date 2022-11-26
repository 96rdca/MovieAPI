using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinesLogic.Interfaces;
using Commons;
using Commons.Models;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using MovieAPI_IonHH.Context;

namespace MovieAPI_IonHH.Controllers;

[ApiController]
[Route("[controller]")]
public class MoviesController : ControllerBase
{
    private readonly IMovieRepository _movieRepository;

    public MoviesController(IMovieRepository repository)
    {
        _movieRepository = repository;
    }

    [HttpPost(Name = "CreateMovie")]
    public async Task<IActionResult> CreateMovie(MovieDTI movie)
    {
        try
        {
           var movieCreated = await _movieRepository.AddMovie(movie);
            return Created(nameof(CreateMovie), movieCreated);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{movieId}", Name = "GetMovie")]
    public IActionResult GetMovie(int movieId)
    {
        try
        {
            var movie = _movieRepository.GetMovie(movieId);
            return Ok(movie);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);

        }
    }

    [HttpGet(Name = "MoviesList")]
    public IActionResult MoviesList([FromQuery] MovieParameters movieParameters)
    {
        try
        {
            var movieList = _movieRepository.GetListMovies(movieParameters);
            return Ok(movieList);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{movieId}/disabled", Name = "DisableMovie")]
    public async Task<IActionResult> DisableMovie(int movieId)
    {
        try
        {
            var isDisabled = await _movieRepository.DisableMovie(movieId);
            return Ok(isDisabled);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}

