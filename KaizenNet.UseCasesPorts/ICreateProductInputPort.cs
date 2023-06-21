using KaizenNet.DTOs;

namespace KaizenNet.UseCasesPorts
{
    public interface ICreateProductInputPort
    {
        Task Handle(CreateProductDTO product);
    }
}
