using AutoMapper;
using Megalopolis.Helpers;
using Megalopolis.Model;
using Megalopolis.Model.Dto;
using Megalopolis.Repository;
using System.Net;

namespace Megalopolis.Service
{
    public class FilmesService
    {
        private readonly FilmesRepository _filmesRepository;
        private readonly IMapper _mapper;

        public FilmesService(FilmesRepository filmesRepository, IMapper mapper)
        {
            _filmesRepository = filmesRepository;
            _mapper = mapper;
        }

        public async Task<Result<bool>> AddFilmes(FilmesDto filmesDto)
        {
            var result = new Result<bool>();
            var filmes = _mapper.Map<Filmes>(filmesDto);
            var res = await _filmesRepository.AddFilmes(filmes);

            return result.AppendData(res, HttpStatusCode.Created);
        }

        public async Task<Result<IEnumerable<Filmes>>> GetFilmes()
        {
            var result = new Result<IEnumerable<Filmes>>();
            var filmes = await _filmesRepository.GetFilmes();

            return result.AppendData(filmes);
        }
    }
}
