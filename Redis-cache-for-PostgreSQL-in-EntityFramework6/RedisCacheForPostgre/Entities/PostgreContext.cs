using System.Data.Entity;

namespace RedisCacheForPostgre.Entities
{
    public class PostgreContext : DbContext
    {
        public PostgreContext() : base(nameOrConnectionString: "PostgreSQL") { }
        public DbSet<Book> Book { get; set; }
    }
}
