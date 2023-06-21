using KaizenNet.DTOs;

namespace KaizenNet.UseCasesPorts
{
    public interface ICreateProductOutputPort
    {
        Task Handle(ProductDTO product);
    }
}
