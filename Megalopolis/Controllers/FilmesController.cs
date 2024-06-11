

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
        [Route("GetFilmes")]
        public async Task<IActionResult> GetFilmes()
        {
            var res = await _filmesService.GetFilmes();
            return StatusCode((int)res.StatusCode, res);
        }
    }
}
