using Microsoft.AspNetCore.Mvc;
using projeto.movie.api.Models;
using projeto.movie.api.Services;
using System.Threading.Tasks;

namespace projeto.movie.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreRepository _genreRepository;

        public GenreController(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllGenreAsync()
        {
            var Genre1= await _genreRepository.GetAllGenre();
            return Ok(Genre1);
        }
        [HttpPost]
        public async Task<ActionResult> AddGenre(Genre genre)
        {
            await _genreRepository.AddGenre(genre);
            return Ok(genre);
        }

        
    }
}
