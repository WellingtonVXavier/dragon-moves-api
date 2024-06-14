using Megalopolis.Data;
using Megalopolis.Helpers;
using Megalopolis.Model;
using Microsoft.EntityFrameworkCore;

namespace Megalopolis.Repository
{
    public class FilmesRepository
    {
        private readonly DataContext _context;
        private readonly ILogger _logger;

        public FilmesRepository(DataContext context, ILogger<FilmesRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<bool> AddFilmes(Filmes filmes)
        {
            await _context.Filmes.AddAsync(filmes);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Filmes>> GetFilmesum()
        {
            return await _context.Filmes
                .ToListAsync();
        }


        public async Task<PagedResult<Filmes>> GetFilmes(int pageNumber, int pageSize)
        {
            var totalItems = await _context.Filmes.CountAsync();
            var items = await _context.Filmes
                                      .OrderBy(f => f.Id)
                                      .Skip((pageNumber - 1) * pageSize)
                                      .Take(pageSize)
                                      .ToListAsync();

            return new PagedResult<Filmes>
            {
                Items = items,
                TotalItems = totalItems,
                PageSize = pageSize
            };
        }

        public async Task<Filmes> GetFilmesById(Guid id)
        {
            return await _context.Filmes
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        internal async Task<bool> UpdateFilme(Filmes filme)
        {
            try
            {
                _context.Update(filme);
                var res = await _context.SaveChangesAsync();

                return res > 0;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                _logger.LogError(ex, ex.Message);
                return false;
            }
        }
    }
}
