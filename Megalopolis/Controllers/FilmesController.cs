

using Megalopolis.Base;
using Megalopolis.Model.Dto;
using Megalopolis.Service;
using Microsoft.AspNetCore.Mvc;

namespace Megalopolis.Controllers
{
    public class FilmesController : BaseController
    {
        private readonly FilmesService _filmesService;

        public FilmesController(FilmesService filmesService)
        {
            _filmesService = filmesService;
        }

        [HttpPost]
        public async Task<IActionResult> CriarFilmes(FilmesDto filmesDto)
        {
            return Ok(await _filmesService.AddFilmes(filmesDto));
        }

        [HttpGet]
        [Route("GetFilmesum")]
        public async Task<IActionResult> GetFilmesum()
        {
            var res = await _filmesService.GetFilmesum();
            return StatusCode((int)res.StatusCode, res);
        }

        [HttpGet]
        [Route("GetFilmes")]
        public async Task<IActionResult> GetFilmes(int pageNumber = 1, int pageSize = 10)
        {
            var res = await _filmesService.GetFilmes(pageNumber, pageSize);
            return StatusCode((int)res.StatusCode, res);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFilmesById(Guid id)
        {
            var res = await _filmesService.GetFilmesById(id);
            return StatusCode((int)res.StatusCode, res);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFilme(FilmesDto filmesDto)
        {
            var res = await _filmesService.UpdateFilme(filmesDto);

            return StatusCode((int)res.StatusCode, res);
        }
    }
}
