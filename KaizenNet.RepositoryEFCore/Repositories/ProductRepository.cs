using KaizenNet.Entities.Interfaces;
using KaizenNet.Entities.POCOs;
using KaizenNet.RepositoryEFCore.DataContext;

namespace KaizenNet.RepositoryEFCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        readonly KaizenNetContext Context;
        public ProductRepository(KaizenNetContext context) =>
            Context = context;
        public void CreateProduct(Product product)
        {
            Context.Add(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return Context.Products;
        }
    }
}
