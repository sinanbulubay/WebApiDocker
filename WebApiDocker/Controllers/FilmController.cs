using Microsoft.AspNetCore.Mvc;

namespace WebApiDocker.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmController : ControllerBase
{
    private readonly DataContext _dataContext;

    public FilmController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    [HttpGet(Name = "GetFilm")]
    public IActionResult GetFilm()
    {
        //var filmList = (
        //        from a in _dataContext.Film
        //        select new
        //        {
        //            a.Id,
        //            a.Title,
        //            a.DurationTime,
        //            a.ReleaseYear,
        //            GenreName = a.Genre.Name
        //        })
        //    .ToList();

        var filmList = _dataContext.Film
            .Select(
                a => new
                {
                    a.Id,
                    a.Title,
                    a.DurationTime,
                    a.ReleaseYear,
                    GenreName = a.Genre.Name
                })
            .ToList();

        if (filmList.Count >= 0)
        {
            return Ok(filmList);
        }

        return NoContent();
    }
}