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

        public async Task<Result<IEnumerable<Filmes>>> GetFilmesum()
        {
            var result = new Result<IEnumerable<Filmes>>();
            var filmes = await _filmesRepository.GetFilmesum();

            return result.AppendData(filmes);
        }

        public async Task<Result<PagedResult<Filmes>>> GetFilmes(int pageNumber, int pageSize)
        {
            var result = new Result<PagedResult<Filmes>>();
            var pagedResult = await _filmesRepository.GetFilmes(pageNumber, pageSize);

            return result.AppendData(pagedResult);
        }

        public async Task<Result<Filmes>> GetFilmesById(Guid id)
        {
            var result = new Result<Filmes>();
            var filmes = await _filmesRepository.GetFilmesById(id);

            return result.AppendData(filmes, HttpStatusCode.Created);
        }

        public async Task<Result<bool>> UpdateFilme(FilmesDto filmesDto)
        {
            var result = new Result<bool>();
            var filme = _mapper.Map<Filmes>(filmesDto);
            var res = await _filmesRepository.UpdateFilme(filme);

            return result.AppendData(res, HttpStatusCode.OK);
        }
    }
}
