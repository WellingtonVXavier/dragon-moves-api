using Megalopolis.Model;
using Microsoft.EntityFrameworkCore;

namespace Megalopolis.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<Filmes> Filmes { get; set; }
}
