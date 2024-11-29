using Microsoft.EntityFrameworkCore;
using proje.Models;

namespace proje.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        { }

        public DbSet<Film> Filmler => Set<Film>();
    }
}
