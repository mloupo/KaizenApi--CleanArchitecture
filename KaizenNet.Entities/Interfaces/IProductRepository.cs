using KaizenNet.Entities.POCOs;

namespace KaizenNet.Entities.Interfaces
{
    public interface IProductRepository
    {
        void CreateProduct(Product product);
        IEnumerable<Product> GetAll();
    }
}
