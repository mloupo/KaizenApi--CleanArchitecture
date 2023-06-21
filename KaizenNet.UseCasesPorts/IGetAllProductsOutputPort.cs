using KaizenNet.DTOs;

namespace KaizenNet.UseCasesPorts
{
    public interface IGetAllProductsOutputPort
    {
        Task Handle(IEnumerable<ProductDTO> products);
    }
}
