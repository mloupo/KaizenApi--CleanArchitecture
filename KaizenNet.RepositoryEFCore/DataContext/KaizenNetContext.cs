using KaizenNet.Entities.POCOs;
using Microsoft.EntityFrameworkCore;

namespace KaizenNet.RepositoryEFCore.DataContext
{
    public class KaizenNetContext : DbContext
    {
        public KaizenNetContext(
            DbContextOptions<KaizenNetContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
