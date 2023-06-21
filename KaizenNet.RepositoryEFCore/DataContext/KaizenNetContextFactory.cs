using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace KaizenNet.RepositoryEFCore.DataContext
{
    public class KaizenNetContextFactory : IDesignTimeDbContextFactory<KaizenNetContext>
    {

        public KaizenNetContext CreateDbContext(string[] args)
        {
            var OptionsBuilder =
            new DbContextOptionsBuilder<KaizenNetContext>();
            OptionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;database=KaizenNet");
            return new KaizenNetContext(OptionsBuilder.Options);
        }
    }
}
