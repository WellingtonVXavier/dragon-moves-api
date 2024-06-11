using Megalopolis.Data;
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

        public async Task<IEnumerable<Filmes>> GetFilmes()
        {
            return await _context.Filmes
                .ToListAsync();
        }
    }
}
