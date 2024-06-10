using Microsoft.EntityFrameworkCore;

namespace Megalopolis.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
        
    }
}
